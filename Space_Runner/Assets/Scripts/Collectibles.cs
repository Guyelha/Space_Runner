using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    [SerializeField] int gems = 0;

    [SerializeField] Text gemsText;

    [SerializeField] AudioClip gemsAudio;


    private void OnTriggerEnter(Collider other) // using trigger enter method to pick up gems collectible and Destroy them from the scene. 
    {
        if(other.gameObject.CompareTag("Collectibles"))
        {
            AudioSource.PlayClipAtPoint(gemsAudio, transform.position);
            Destroy(other.gameObject);
            gems++;
            gemsText.text = "Gems:" + gems;


        }
    }
}
