using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdatePlayerInfo : MonoBehaviour
{
    private SpriteRenderer playerSprite;
    private ShowAvatarList avatarList;
    private List<string> playerNames;
    [SerializeField]private TextMeshProUGUI playerName;
    // Start is called before the first frame update

    private void Awake()
    {
        playerSprite = GameObject.Find("PlayerSprite").GetComponent<SpriteRenderer>();
        avatarList = GameObject.Find("AvatarList").GetComponent<ShowAvatarList>();
        playerNames = GameObject.Find("OnlineButton").GetComponent<ShowOnlineList>().onlineList;
    }
    void Start()
    {
        playerSprite.sprite = avatarList.avatars[PlayerPrefs.GetInt("PlayerAvatar")];
        playerName.text = PlayerPrefs.GetString("PlayerName");
        playerNames.Add(playerName.text);
    }

    public void UpdateInfo()
    {
        playerSprite.sprite = avatarList.avatars[PlayerPrefs.GetInt("PlayerAvatar")];
        playerName.text = PlayerPrefs.GetString("PlayerName");
    }
}
