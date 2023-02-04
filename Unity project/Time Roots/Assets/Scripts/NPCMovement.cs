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

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Debug.Log(NPC.age);
    }

    void Update()
    {
        movement();
    }

    void movement(){
        switch (status)
        {
            case 0:
                direction = (target0.position - transform.position).normalized;
                rigidbody2D.velocity = direction * 3;

                if (Vector2.Distance(transform.position, target0.position) < 1f)
                {
                    status = 1;
                    break;
                }
                break;
            case 1:
                direction = (target1.position - transform.position).normalized;
                rigidbody2D.velocity = direction * 4;

                if (Vector2.Distance(transform.position, target1.position) < 1.5f)
                {
                    status = 2;
                }
                break;
            case 2:
                direction = (target2.position - transform.position).normalized;
                rigidbody2D.velocity = direction * 3;

                if (Vector2.Distance(transform.position, target2.position) < 1.5f)
                {
                    status = 3;
                }
                break;
            case 3:
                direction = (target3.position - transform.position).normalized;
                rigidbody2D.velocity = direction * 5;

                if (Vector2.Distance(transform.position, target3.position) < 1.5f)
                {
                    status = 0;
                }
                break;
        }
    }

    void updateAnimation()
    {
        // To-do
    }
}
