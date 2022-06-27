using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovementScript : MonoBehaviour
{
    public bool currentlyMovingRight;
    [Range(0, 100)]
    public float movementSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (currentlyMovingRight)
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
            if (transform.position.x > 8.3f)

                currentlyMovingRight = !currentlyMovingRight;

        }
        else if (!currentlyMovingRight)
        {
            transform.position += new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
            if (transform.position.x < -8.3f)
                currentlyMovingRight = !currentlyMovingRight;

        }
       
            
    }
}
