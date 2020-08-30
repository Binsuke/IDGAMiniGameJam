using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;

    }
}
