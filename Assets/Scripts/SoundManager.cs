using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;

	public AudioClip music1;
	public AudioClip correctSound;
	public AudioClip hitSound;

	void Awake()
	{
		instance = this;
		DontDestroyOnLoad(this);
	}

	// Use this for initialization
	public void PlayAudio (AudioClip clip) 
	{
		GetComponent<AudioSource>().clip = clip;
		GetComponent<AudioSource>().Play();
		if (clip.name == "music1")
			GetComponent<AudioSource>().loop = true;
		else
			GetComponent<AudioSource>().loop = false;
	}
}
