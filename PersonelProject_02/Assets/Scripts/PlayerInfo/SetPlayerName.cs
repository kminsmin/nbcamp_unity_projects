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
    private List<string> names;
    //private ShowAvatarList avatarList;

    private void Awake()
    {
        names = GameObject.Find("OnlineButton")?.GetComponent<ShowOnlineList>().onlineList;
    }
    public void SavePlayerName()
    {
        if (playerNameText.text.Length >= 3 && playerNameText.text.Length <= 10)
        {
            names.Remove(PlayerPrefs.GetString("PlayerName"));
            PlayerPrefs.SetString("PlayerName", playerNameText.text);
            names.Add(PlayerPrefs.GetString("PlayerName"));
            namePanel.SetActive(false);
            Time.timeScale = 1.0f;
        }

        else
            errorMessage.text = "2글자에서 10글자 사이로 해주세요!";
        Debug.Log(PlayerPrefs.GetString("PlayerName"));
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
