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
            if (uiElement.gameObject.tag == "NPC Name") { Debug.Log("Found Name"); uiElement.GetComponent<TextMeshProUGUI>().text = npcToRead.characterName; }
            if (uiElement.gameObject.tag == "NPC Avatar") { Debug.Log("Found dialogue"); uiElement.GetComponent<Image>().sprite = npcToRead.uiAvatar; }
            if (uiElement.gameObject.tag == "NPC Dialogue") { Debug.Log("Found Pic"); uiElement.GetComponent<TextMeshProUGUI>().text = npcToRead.dialogueMsg; }
        }
        //textMesh.text = message;
    }
}
