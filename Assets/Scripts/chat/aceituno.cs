using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aceituno : MonoBehaviour
{
    [SerializeField] private int DefaultchatMessageCount;
    [SerializeField] private string DefaultchatMessage;
    [SerializeField] private int ChestChatMessageCount;
    [SerializeField] private string ChestChatMessage;
    // Update is called once per frame
    void Update()
    {
        // if player has opened the chest
        if (GameObject.Find("GameManager").GetComponent<GameManager>().chestOpenend)
        {
            // if the text is not the default text
            if (this.GetComponent<chat>().GetchatMessage() != ChestChatMessage)
            {
                // set the text to default text
                this.GetComponent<chat>().SetchatMessage(ChestChatMessage);
                this.GetComponent<chat>().SetchatsCount(ChestChatMessageCount);
            }
        }
        else
        {
            // if the text is not the default text
            if (this.GetComponent<chat>().GetchatMessage() != DefaultchatMessage)
            {
                // set the text to default text
                this.GetComponent<chat>().SetchatMessage(DefaultchatMessage);
                this.GetComponent<chat>().SetchatsCount(DefaultchatMessageCount);
            }
        }
    }
}
