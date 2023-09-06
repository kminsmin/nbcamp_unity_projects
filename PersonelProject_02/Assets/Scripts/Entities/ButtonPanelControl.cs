using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanelControl : MonoBehaviour
{
    [SerializeField] private GameObject closingText;
    [SerializeField] private GameObject openingText;

    public void OpenConversation()
    {
        openingText.SetActive(true);
        closingText.SetActive(false);
        Time.timeScale = 0.0f;
    }

    public void CloseConversation()
    {
        closingText.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
