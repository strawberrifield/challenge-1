using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public GameObject Player;
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;
    
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        // Moves the plane forward based on vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        // Move the plane forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the plane based on horizontal input
        transform.position = plane.transform.position + offset + new Vector3(19, 3, -2);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        transform.Rotate(Vector3.down, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
