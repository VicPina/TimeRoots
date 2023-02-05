using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sfx, music;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sfx)
        {
            if (s.source == null) { s.source = gameObject.AddComponent<AudioSource>(); }
            s.source.clip = s.clip;
            s.source.loop = s.loop;
            s.source.volume = s.volume;
            s.source.outputAudioMixerGroup = s.mixerGroup;
        }
        foreach (Sound s in music)
        {
            if (s.source == null) { s.source = gameObject.AddComponent<AudioSource>(); }
            s.source.clip = s.clip;
            s.source.loop = s.loop;
            s.source.volume = s.volume;
            s.source.outputAudioMixerGroup = s.mixerGroup;
        }
    }
    public AudioSource FindSound(string name)
    {
        Sound s = Array.Find(sfx, sound => sound.fileName == name);
        Debug.Log(s.source.clip);
        return s.source;
    }
    public void PlaySFXClip(string name)
    {
        Sound s = Array.Find(sfx, sound => sound.fileName == name);
        s.source.Play();
    }
    public void PauseSFXClip(string name)
    {
        Sound s = Array.Find(sfx, sound => sound.fileName == name);
        s.source.Pause();
    }
    public void StopSFXClip(string name)
    {
        Sound s = Array.Find(sfx, sound => sound.fileName == name);
        s.source.Stop();
    }
    public void PlayMusicClip(string name)
    {
        Sound s = Array.Find(music, sound => sound.fileName == name);
        s.source.Play();
    }
    public void PauseMusicClip(string name)
    {
        Sound s = Array.Find(music, sound => sound.fileName == name);
        s.source.Pause();
    }
    public void StopMusicClip(string name)
    {
        Sound s = Array.Find(music, sound => sound.fileName == name);
        s.source.Stop();
    }
}

[System.Serializable]
public class Sound
{
    public string fileName;

    [Space(10)]
    public AudioClip clip;
    public AudioSource source;

    [Space(10)]
    public bool loop;
    [Range(0f, 1f)]
    public float volume;

    [Space(10)]
    public AudioMixerGroup mixerGroup;
}