using UnityEngine;
using System.Collections;

public class AudioRandom : MonoBehaviour {
	
	public AudioClip[] audio_clip;
	// Use this for initialization
	void Start () {
		audio.mute = !PlayerPrefsX.GetBool("sound");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnEnable ()
	{
		if(audio){
			int rnd = Random.Range (0, audio_clip.Length);
			audio.clip = audio_clip [rnd];
			audio.Play ();
		}
	}
}
