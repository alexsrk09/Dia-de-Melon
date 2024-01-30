using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chat : MonoBehaviour
{
    [SerializeField] private float distance=0.3f;
    [SerializeField] private GameObject canvas;
    [SerializeField] private bool repetible;
    public int chatsCount;

    [SerializeField] private string chatMessage;
    private string[] chatMessages;
    private int chatMessageCount;
    // Start is called before the first frame update
    void Start()
    {
        // Split the chat message *
        chatMessages = chatMessage.Split('*');
        chatMessageCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        // getkey find Gamemanager interactkey
        if (Input.GetKeyDown(GameObject.Find("GameManager").GetComponent<GameManager>().interactKey)
        // if player tagged gameobject is near
        && Vector2.Distance(GameObject.FindWithTag("Player").transform.position, transform.position) < distance
        )
        {
            canvas.SetActive(true);
            // if chatmessagecount is less than chatmessage length
            if (chatMessageCount < chatsCount)
            {
                GameObject.FindWithTag("Player").GetComponent<Player>().SetControllable(false);
                // message in parts splited by "$"
                string[] messageParts = chatMessages[chatMessageCount].Split('$');
                // update canvas
                // if first part is 1
                if (messageParts[0] == "1")
                {
                    // update canvas with first part of the second part
                    canvas.GetComponent<Canvas>().UpdateCanvas(int.Parse(messageParts[0]), int.Parse(messageParts[1]), 0, 0);
                }
                else
                {
                    // update canvas with first part of the second part
                    canvas.GetComponent<Canvas>().UpdateCanvas(0, 0, int.Parse(messageParts[0]), int.Parse(messageParts[1]));
                }
                // print chatmessage
                canvas.GetComponent<Canvas>().PrintChatMessage(messageParts[2]);
                // add 1 to chatmessagecount
                chatMessageCount++;
            }
            else // if chatmessagecount is greater than chatmessage length
            {
                // disable canvas
                canvas.SetActive(false);
                GameObject.FindWithTag("Player").GetComponent<Player>().SetControllable(true);
                Debug.Log("end of chat");
                // reset chatmessagecount if repetible
                if (repetible) chatMessageCount = 0;
            }
        }
    }
    public void SetchatMessage(string message)
    {
        chatMessage = message;
        chatMessages = chatMessage.Split('*');
        chatMessageCount = 0;
    }
    public string GetchatMessage()
    {
        return chatMessage;
    }
    public void SetchatsCount(int count)
    {
        chatsCount = count;
    }
}
