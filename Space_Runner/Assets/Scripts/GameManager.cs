using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    
    public bool lostGame = false;
    public GameObject LostCanvas;
    public GameObject WinningCanvas;
    public bool wonGame = false;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void LostGame()  // activating lost canvas using game object variable when lost game bool is true.
    {
        if(!lostGame)
        {
            lostGame = true;
            LostCanvas.SetActive(true);
          

        }
    }
    public void RestartGame()// reset the scene after LostGame(), using UI button,and sceneManagment.
    {
        PlayerPrefs.SetInt("Gems:", PlayerPrefs.GetInt("Gems:")+ FindObjectOfType <MovementScript>().score);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    public void WonGame()// calling the winning canvas to activate when wonGame bool is true.
    {
        if(!wonGame)
        {
            wonGame = true;
            WinningCanvas.SetActive(true);
            
        }
    }

    public void LoadNextLevel()// loading next scene when level is complete using, UI butoon and sceneManager.

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }





}
