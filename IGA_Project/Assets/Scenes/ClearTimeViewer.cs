using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClearTimeViewer : MonoBehaviour
{
    float clearTime;
    // Start is called before the first frame update
    void Start()
    {
        clearTime = PlayerPrefs.GetFloat("Time", 0);
        GetComponent<Text>().text = clearTime.ToString("F2");
        PlayerPrefs.DeleteKey("Time");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
