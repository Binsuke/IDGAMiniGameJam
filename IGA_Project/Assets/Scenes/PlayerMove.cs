using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rig;

    //Player Move Spered
    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトのRigidbody　コンポーネントの取得
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rig.AddForce(new Vector3(0, 0, moveSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rig.AddForce(new Vector3(0, 0, -moveSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rig.AddForce(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rig.AddForce(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);
        }

        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
