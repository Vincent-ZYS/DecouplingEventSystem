using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestShowTxt : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
        //EventCenter.AddListener(EventType.ShowText, Show);
        EventCenter.AddListener<string>(EventType.ShowText, Show);
    }

    private void OnDestroy()
    {
        //EventCenter.RemoveListener(EventType.ShowText, Show);
        EventCenter.RemoveListener<string>(EventType.ShowText, Show);
    }

    private void Show(string str)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str;
    }

}
