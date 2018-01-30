using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour {

    public AudioClip audio;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.AddComponent<AudioSource>();
        if (audio != null)
            audioSource.clip = audio;
        audioSource.playOnAwake = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayAudio()
    {
        GetComponent<Button>().onClick.AddListener(() => audioSource.PlayOneShot(audio));
    }
}
