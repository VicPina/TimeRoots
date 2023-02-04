using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInfoTest : MonoBehaviour
{
    // UI info to send
    public string characterName;
    public string dialogueMsg;
    public Sprite uiAvatar;

    // Audio test *unrelated
    [Space(10)]
    public AudioManager audioManager;
    public void PlayAudioOnceTest(string audio)
    {
        AudioSource source = audioManager.FindSound(audio);
        Debug.Log(source.clip);
        source.PlayOneShot(source.clip);
        //source.Play();
    }
}
