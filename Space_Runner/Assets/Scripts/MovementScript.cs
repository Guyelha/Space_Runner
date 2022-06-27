using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float forwardSpeed = 1000;
    public float sideSpeed = 500;
    public int score;
    Rigidbody rb;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //Making connection between rb variable and the rigidbody component.
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() // using addforce to make connection between forwardspeed variable and the rigidbody component.
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime); 
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0);
        }
    }

    // making connection between player transform and LostGame() and player score.
    void Update()
    {
        if(transform.position.y< -2.5)
        {
            gameManager.LostGame();
        }
        score = (int)Mathf.Round(transform.position.z * 15);
    }
}
