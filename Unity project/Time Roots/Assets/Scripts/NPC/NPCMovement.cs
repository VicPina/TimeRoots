using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public BasicNPC NPC;
    public int speed = 2;
    public Transform target0;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    public Transform target7;
    public Transform target8;
    public Transform target9;
    public Transform target10;
    public Transform target11;
    public Transform target12;
    public Transform target13;
    public Transform target14;

    Rigidbody2D rigidbody2D;
    Vector2 direction;

    public Animator anim;

    public int status = 0;

    // The places that the NPCs visit
    public Transform[] targets;
    public int numberofTargets = 15;

    // private moveDirection = new Vector2;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        //Debug.Log(NPC.age);


        targets = new Transform[numberofTargets];

        // Assign Transform components to each element in the array
        // Assign the positions to visit
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i] = gameObject.GetComponent<Transform>();
        }

        int id=0;

        // id = basicNPC.id;
        // Debug.Log(id); can fetch from basicNPC
    }


    
    void Update()
    {
        movement();
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        // moveDirection = new Vector2(moveX, moveY).normalized;
        animate();
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
            case 4:
                moveTo(target4);
                break;
            case 5:
                moveTo(target5);
                break;
            case 6:
                moveTo(target6);
                break;
            case 7:
                moveTo(target7);
                break;
            case 8:
                moveTo(target8);
                break;
            case 9:
                moveTo(target9);
                break;
            case 10:
                moveTo(target10);
                break;
            case 11:
                moveTo(target11);
                break;
            case 12:
                moveTo(target12);
                break;
            case 13:
                moveTo(target13);
                break;
            case 14:
                moveTo(target14);
                break;
        }
    }

    void moveTo(Transform target){
        direction = (target.position - transform.position).normalized;
        rigidbody2D.velocity = direction * speed;
        // Debug.Log(direction.x);


        if (Vector2.Distance(transform.position, target.position) < 1f)
        {
            //status is used as an indicator to show which place from an ordered list of places to go to next
            //The list should be unique to every NPC
            if (status<14){
                status = status+1;
            } else{
                status =0;
            }
        }
    }

    void animate(){
        anim.SetFloat("AnimMoveX", direction.x);
        anim.SetFloat("AnimMoveY", direction.y);
    }
}
