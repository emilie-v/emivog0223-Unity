using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioVariation : MonoBehaviour
{
	//An array with the different audio clips.
	public AudioClip[] audioClips;

	//Reference to our AudioSource
	AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();

		if (audioClips.Length > 0)
		{
			//Select a random clip from our array with clips
			int rndIndex = Random.Range(0, audioClips.Length);
			audioSource.clip = audioClips[rndIndex];

			audioSource.pitch = Random.Range(0.8f, 1.2f);

			audioSource.Play();
		}
	}
}

public class Shoot : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
