using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SetPlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI playerNameText;
    //private ShowAvatarList avatarList;


    public void SavePlayerName()
    {
        PlayerPrefs.SetString("PlayerName", playerNameText.text);
        Debug.Log(PlayerPrefs.GetString("PlayerName"));
    }

    public void ChangeToMain()
    {
        // = GameObject.Find("AvatarList").GetComponent<ShowAvatarList>();
        PlayerPrefs.SetString("PlayerName", playerNameText.text);
        //Debug.Log(PlayerPrefs.GetString("PlayerName")+$"Avatar : {PlayerPrefs.GetInt("PlayerAvatar")}");
        SceneManager.LoadScene("MainScene");
    }
}
