using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelectScript : MonoBehaviour
{
    public Material skin1;
    public Material skin2;
    // Start is called before the first frame update
    void Start()
    {
        ChooseSkin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseSkin()
    {
        if (PlayerPrefs.GetInt("SkinNumber") == 0)
        {
            GetComponent<MeshRenderer>().material = skin1;
        }
        else if(PlayerPrefs.GetInt("SkinNumber") == 1)

            GetComponent<MeshRenderer>().material = skin2;


    }
}
