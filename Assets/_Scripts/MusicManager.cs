using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;
    public List<AudioClip> crashClips;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayCrashSound()
    {
        GetComponent<AudioSource>().PlayOneShot(crashClips[Random.Range(0, crashClips.Count)]);
    }

}
