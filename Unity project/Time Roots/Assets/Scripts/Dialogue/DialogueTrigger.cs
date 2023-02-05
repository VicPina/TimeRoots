using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ref:
// Holds a list of messages and actors
// Sends messages to manager
// Holds seperate data for each NPC

public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Message
{
    public int actorID;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}