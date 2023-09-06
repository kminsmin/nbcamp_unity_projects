using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    [SerializeField] GameObject NPCPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NPCPanel.SetActive(true);
        //Debug.Log("hi");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NPCPanel.SetActive(false);
        //Debug.Log("bye");
    }
}
