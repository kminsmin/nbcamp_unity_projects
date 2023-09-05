using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAvatarList : MonoBehaviour
{
    public Sprite[] avatars;
    public Image currentAvatar;
    public int avatarIndex = 0;


    private void Awake()
    {
        currentAvatar = GameObject.Find("AvatarSprite").GetComponent<Image>();
    }
    public void NextAvatar()
    {
        avatarIndex++;
        if (avatarIndex >= avatars.Length)
        {
            avatarIndex = 0;
        }
        currentAvatar.sprite = avatars[avatarIndex];
        PlayerPrefs.SetInt("PlayerAvatar", avatarIndex);

    }

    public void PreviousAvatar()
    {
        avatarIndex--;
        if (avatarIndex < 0)
        {
            avatarIndex = avatars.Length - 1;
        }
        currentAvatar.sprite = avatars[avatarIndex];
        PlayerPrefs.SetInt("PlayerAvatar", avatarIndex);
    }
}
