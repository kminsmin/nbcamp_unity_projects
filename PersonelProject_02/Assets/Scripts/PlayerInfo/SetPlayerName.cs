using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SetPlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI playerNameText;
    [SerializeField] private TextMeshProUGUI errorMessage;
    [SerializeField] private GameObject namePanel; 
    //private ShowAvatarList avatarList;


    public void SavePlayerName()
    {
        if (playerNameText.text.Length >= 3 && playerNameText.text.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", playerNameText.text);
            namePanel.SetActive(false);
            Time.timeScale = 1.0f;
        }

        else
            errorMessage.text = "2글자에서 10글자 사이로 해주세요!";
    }

    public void ChangeToMain()
    {
        if (playerNameText.text.Length >= 3 && playerNameText.text.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", playerNameText.text);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            errorMessage.text = "2글자에서 10글자 사이로 해주세요!";
            return;
        }
        
    }

    public void ActivateNamePanel()
    {
        namePanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
