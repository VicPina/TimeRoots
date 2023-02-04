using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "NPC")]
public class BasicNPC : ScriptableObject
{
    public BasicNPC mom;
    public BasicNPC dad;
    public new string name; //check "new" keyword
    public string hairColor;
    public string gender;
    public string race; //?

    public Sprite artwork;


    public int age; //increment with every year

    //Check that an NPC cant be a parent of thier own: NPC rules


}
