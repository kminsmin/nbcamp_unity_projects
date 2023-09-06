using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowOnlineList : MonoBehaviour
{
    [SerializeField] private GameObject onlinePanel;
    [SerializeField] private TextMeshProUGUI onlineText;
    public List<string> onlineList = new List<string>();
    // Start is called before the first frame update
    public void ActivateOnlinePanel()
    {
        onlinePanel.SetActive(true);
        onlineText.text = $"nbcamp_unity\n";
        foreach(string name in onlineList)
        {
            onlineText.text += "\n" + name;
        }
    }

    public void DeactivateOnlinePanel()
    {
        onlinePanel.SetActive(false);
    }
}
