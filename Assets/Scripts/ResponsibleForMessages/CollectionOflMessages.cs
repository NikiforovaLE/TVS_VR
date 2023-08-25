using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionOflMessages : MonoBehaviour
{
    [SerializeField] private Text allMessages;

    private readonly List<string> messages = new();
    private string allMessagesInOneString;

    public void AddMessage(string date, string time, string message, string status)
    {
        messages.Add(date + " " + time + " " + message + " " + status);
    }

    public void ShowAllMessages()
    {
        allMessages.text = CollectAllMessagesToOneString();
    }

    private string CollectAllMessagesToOneString()
    {
        foreach (string message in messages)
        {
            allMessagesInOneString = message + "\r\n";
        }
        return allMessagesInOneString;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
