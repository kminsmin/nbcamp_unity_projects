using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DisplayTime : MonoBehaviour
{
    private TextMeshProUGUI timeText;

    private void Awake()
    {
        timeText = GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = DateTime.Now.ToShortTimeString();
    }
}
