using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "NPC")]
public class BasicNPC : ScriptableObject
{
    public BasicNPC mom;
    public BasicNPC dad;
    public new string name; //( To-Do check "new" keyword)
    public string hairColor;
    public string gender;
    public string race; //?
    public int stage; //To indicate which set of dialog tp show
    public string[] hints; //The list of dialoge to be presented

    public Sprite artwork;

    public Button click;


    public int age; //increment with every year

    //Check that an NPC cant be a parent of thier own: NPC rules

    void Update()
    {
        // click.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("NPC clicked");
    }
}
