using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerPosition;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = playerPosition.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPosition.position - offset;
    }
}
