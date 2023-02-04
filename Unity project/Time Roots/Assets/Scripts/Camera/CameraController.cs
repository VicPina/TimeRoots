using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference: https://www.youtube.com/watch?v=rnqF6S7PfFA

public class CameraController : MonoBehaviour
{
    public float movementSpeed;
    public float movementTime;

    public Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        // get keyboard input from player
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            // forward direction
            newPosition += (transform.up * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            // backward direction 
            newPosition += (transform.up * -movementSpeed);

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // right direction
            newPosition += (transform.right * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // right direction
            newPosition += (transform.right * -movementSpeed);
        }

        // interpolate between current pos and new pos to get a smoother transition
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementSpeed);
    }
}
