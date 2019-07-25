using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusicPlayer : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip[] audioClips;

	void Start () {
        audioSource = GetComponent<AudioSource>();
        PlayAudio();

    }

    public void PlayAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        int index = Random.Range(0, audioClips.Length);
        audioSource.clip = audioClips[index];
        audioSource.Play();
        Invoke("PlayAudio", audioClips[index].length);
    }
	


}
