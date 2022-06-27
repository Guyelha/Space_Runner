using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public MovementScript movementScript;
    public GameObject LostCanvas;
    public GameManager gameManager;
    public GameObject Player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.transform.tag=="Enemy")
        {
            movementScript.enabled = false;
            Player.GetComponent<Rigidbody>().isKinematic = true;
             gameManager.LostGame();
           
            
            
        }
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
