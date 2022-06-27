using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkinScript : MonoBehaviour
{
    public Text secondSkinText;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Skin2") == 0)
        {
            secondSkinText.text = "Buy Skin 1000";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressedSkin1()
    {
        PlayerPrefs.SetInt("SkinNumber", 0);
        FindObjectOfType<SkinSelectScript>().ChooseSkin();
            

      
    }

    public void PressedSkin2()
    {
        if(PlayerPrefs.GetInt("Skin2")==0)
        {
            if(PlayerPrefs.GetInt("Coins:")>1000)
            {
                PlayerPrefs.SetInt("Coins:", PlayerPrefs.GetInt("Coins:") - 1000);
                PlayerPrefs.SetInt("Skin2", 1);
                PlayerPrefs.SetInt("SkinNumber", 1);
                FindObjectOfType<SkinSelectScript>().ChooseSkin();
                secondSkinText.text = "Buy Skin 1000";
            }
        }
        else
        {
            PlayerPrefs.SetInt("SkinNumber", 1);
            FindObjectOfType<SkinSelectScript>().ChooseSkin();
        }
    }

    public void Back()
    {
        gameObject.SetActive(false);
    }


}
