using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float countTime = 0;
    Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
        countTime = PlayerPrefs.GetFloat("Time", 0);
    }

    // Update is called once per frame
    void Update()
    {
        countTime +=Time.deltaTime;//スタートしてからの秒数を格納
        timeText.text = countTime.ToString("F2");//少数２桁にして表示
    }

    void OnDisable()
    {
        PlayerPrefs.SetFloat("Time", countTime);
        PlayerPrefs.Save();
    }
}
