using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class JumpCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float jumpPower = 500.0f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpPower, 0));

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
