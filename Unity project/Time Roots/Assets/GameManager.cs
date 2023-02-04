using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public RectTransform npcPanel;
    
    private void SetNpcPanel()
    {
        // NPC Dialogue
        // NPC Name
        // NPC Avatar

    }

    public void OpenTextPanel(NPCInfoTest npcToRead)
    {
        foreach (RectTransform uiElement in npcPanel)
        {
            if (uiElement.gameObject.tag == "NPC Name") { uiElement.GetComponent<TextMeshProUGUI>().text = npcToRead.characterName; }
            if (uiElement.gameObject.tag == "NPC Avatar") { uiElement.GetComponent<TextMeshProUGUI>().text = npcToRead.characterName; }
            if (uiElement.gameObject.tag == "NPC Name") { uiElement.GetComponent<Image>().sprite = npcToRead.uiAvatar; }
        }
        npcPanel.gameObject.SetActive(true);
        //textMesh.text = message;
    }
}
