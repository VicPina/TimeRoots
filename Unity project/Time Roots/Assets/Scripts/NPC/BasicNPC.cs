using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "NPC")]
public class BasicNPC : MonoBehaviour
{
    // don't think we need mom and dad referenced this way or any of this other stuff other than name and 
    //public BasicNPC mom;
    //public BasicNPC dad;
    //public int age; //increment with every year
    [Header("Info to send")]
    [Tooltip("Image to show in dialogue")]
    public Sprite NPCSprite;
    [Tooltip("NPCs character name")]
    public string NPCName;
    [HideInInspector]
    public string messageToShow;
    [Tooltip("Check if this character is going to be interactable multiple times")]
    public bool multipleDialogues;
    [Tooltip("List of dialogues")]
    public string[] dialogueMessages;
    [HideInInspector]
    public int numConversations; //To indicate which set of dialog tp show - currently not being used but here if we have time. 
    private void Awake()
    {
        //click = GetComponentInChildren<Button>();
        numConversations = 0;
        messageToShow = dialogueMessages[numConversations];
    }
    public void CheckForMoreDialogues()
    {
        if (multipleDialogues && numConversations<=dialogueMessages.Length)
        {
            numConversations++;
            messageToShow = dialogueMessages[numConversations];
        }
    }
    /*
     * 
     * / MARK - Dialogue
    public GameObject DialoguePanel;
    //public Message[] dialogueMessages; //The list of dialoge to be presented
    public Actor[] dialogueParticipants;

    // MARK - Interactable
    private Button click;

    //Check that an NPC cant be a parent of thier own: NPC rules

    void Start()
    {
        click.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Open up the dialogue
        // TODO - can set the position above via: Instantiate(GameObject objectToSpawn, Vector3 position, Quaternion rotation);
        GameObject dialoguePanel = Instantiate(DialoguePanel);
        DialogueManager dialogueManager = dialoguePanel.GetComponent<DialogueManager>();
        dialogueManager.OpenDialogue(dialogueMessages, dialogueParticipants);

        Debug.Log("NPC clicked");
    }

    public void ShowDialogue()
    {
        GameObject dialoguePanel = Instantiate(DialoguePanel);
        DialogueManager dialogueManager = dialoguePanel.GetComponent<DialogueManager>();
        dialogueManager.OpenDialogue(dialogueMessages, dialogueParticipants);
    }
    */
}
