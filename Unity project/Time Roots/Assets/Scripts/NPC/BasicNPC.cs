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
    public string NPCName;
    public Sprite NPCSprite;
    public int numConversations; //To indicate which set of dialog tp show - currently not being used but here if we have time. 

    // MARK - Dialogue
    public GameObject DialoguePanel;
    public Message[] dialogueMessages; //The list of dialoge to be presented
    public Actor[] dialogueParticipants;

    // MARK - Interactable
    public Button click;

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
}
