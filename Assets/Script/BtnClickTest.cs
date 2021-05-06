using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnClickTest : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            //EventCenter.BroadCast(EventType.ShowText);
            EventCenter.BroadCast(EventType.ShowText,"Hello!!!");
        });
    }
}
