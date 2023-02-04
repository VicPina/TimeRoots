using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public BasicNPC NPC;
    public Transform target0;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    Rigidbody2D rigidbody2D;
    Vector2 direction;
    public int status = 0;

    // The places that the NPCs visit
    public Transform[] targets;
    public int numberofTargets = 4;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Debug.Log(NPC.age);

        targets = new Transform[numberofTargets];

        // Assign Transform components to each element in the array
        // Assign the positions to visit
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i] = gameObject.GetComponent<Transform>();
        }
    }

    void Update()
    {
        movement();
    }

    void movement(){

        switch (status)
        {
            //Targets are placeholders for locations to visit
            case 0:
                moveTo(target0);
                break;
            case 1:
                moveTo(target1);
                break;
            case 2:
                moveTo(target2);
                break;
            case 3:
                moveTo(target3);
                break;
        }
    }

    void moveTo(Transform target){
        direction = (target.position - transform.position).normalized;
        rigidbody2D.velocity = direction * 3;

        if (Vector2.Distance(transform.position, target.position) < 1f)
        {
            //status is used as an indicator to show which place from an ordered list of places to go to next
            //The list should be unique to every NPC
            status = status+1;
        }
    }

    void updateAnimation()
    {
        // To-do
    }
}
