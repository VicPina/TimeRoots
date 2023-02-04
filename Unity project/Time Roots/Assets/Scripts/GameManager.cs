using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform npcPanel;

    public void OpenTextPanel(NPCInfoTest npcToRead)
    {
        npcPanel.gameObject.SetActive(true);
        foreach (Transform uiElement in npcPanel)
        {
            if (uiElement.gameObject.tag == "NPC Name") { uiElement.GetComponent<TextMeshProUGUI>().text = npcToRead.characterName; }
            if (uiElement.gameObject.tag == "NPC Avatar") { uiElement.GetComponent<Image>().sprite = npcToRead.uiAvatar; }
            if (uiElement.gameObject.tag == "NPC Dialogue") { uiElement.GetComponent<TextMeshProUGUI>().text = npcToRead.dialogueMsg; }
        }
    }
}
