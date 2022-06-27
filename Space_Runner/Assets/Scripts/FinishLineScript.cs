using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineScript : MonoBehaviour
{
    public GameObject Player;
    public MovementScript movementScript;
    public GameManager gameManager;
    public GameObject winningCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other) // calling for MovementScript component using Trigger Method to activate WonGame().
    {
        if(other.GetComponent<MovementScript>())
        {
            movementScript.enabled = false;
            Player.GetComponent<Rigidbody>().isKinematic = true;
            gameManager.WonGame();
            print("won game");   
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
