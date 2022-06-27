using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropingTrapScript : MonoBehaviour
{
    public bool currentlyMovingDown;
    [Range(0, 100)]
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   private void FixedUpdate()
    {
        if (currentlyMovingDown)
        {
            transform.position += new Vector3(0, movementSpeed * Time.deltaTime, 0);
            if (transform.position.y > 9.5f)

                currentlyMovingDown = !currentlyMovingDown;

        }
        else if (!currentlyMovingDown)
        {
            transform.position += new Vector3(0, -movementSpeed * Time.deltaTime, 0);
            if (transform.position.y < 0.75f)
                currentlyMovingDown = !currentlyMovingDown;

        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    
}
