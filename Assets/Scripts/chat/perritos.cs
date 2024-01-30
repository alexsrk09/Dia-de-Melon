using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perritos : MonoBehaviour
{
    [SerializeField] private string DefaultchatMessage;
    [SerializeField] private string OpenedchatMessages;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().key) {
            if (this.GetComponent<chat>().GetchatMessage() != OpenedchatMessages)
                {
                    // set the text to default text
                    this.GetComponent<chat>().SetchatMessage(OpenedchatMessages);
                }
        }
        else
        {
            // if the text is not the default text
            if (this.GetComponent<chat>().GetchatMessage() != DefaultchatMessage)
            {
                // set the text to default text
                this.GetComponent<chat>().SetchatMessage(DefaultchatMessage);
            }
        }
    }
}
