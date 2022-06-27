using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainWidget : MonoBehaviour
{
    public Text scoreText;
    
    public Transform playerLocation;
    public MovementScript movementscript;
    public GameObject player;
    public GameObject startGameButton;
    public GameObject levelHolder;
    public GameObject selectLevelButton;
    public GameObject chooseSkinButton;
    public GameObject skinsCanvas;
    public GameObject menuImage;

    // Start is called before the first frame update// calling the MovementScript on Start, making connection between Coins text and playerPrefs converting integere to string.
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE:" + FindObjectOfType<MovementScript>().score.ToString();
    }

    public void StartGame()// enable MovementScriot component and disabeling all UI buttons when StartGame() is active.
    {
        player.GetComponent<MovementScript>().enabled = true;
        startGameButton.SetActive(false);
        levelHolder.SetActive(false);
        selectLevelButton.SetActive(false);
        chooseSkinButton.SetActive(false);
        menuImage.SetActive(false);
    }

    public void OpenLevelHolder()// termms for when levelHolder GameObject is active.
    {
        if(levelHolder.activeSelf)
        {
            levelHolder.SetActive(false);
        }
        else 
            levelHolder.SetActive(true);
    }
    // calling each scene using the sceneManager 
    public void OpenLevel1()
    {
        SceneManager.LoadScene(0);
       
    }
    public void OpenLevel2()
    {
        SceneManager.LoadScene(1);
        
    }
    public void OpenLevel3()
    {
        SceneManager.LoadScene(2);
     
    }

    public void OpenSkinTab()// making connection between skinsCanvas and the game object variable.
    {
        skinsCanvas.SetActive(true);
    }
}
