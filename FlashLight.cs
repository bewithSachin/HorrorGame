using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
	public AudioClip soundOn;
	public AudioClip soundOff;
	void Update () {
		if (Input.GetKeyDown("f")) 
		{ if(GetComponent<Light>().enabled == false) 
		{ 
				GetComponent<Light>().enabled = true; 
		GetComponent<AudioSource>().clip = soundOn; 
		GetComponent<AudioSource>().Play(); 
			} 
		else { 
			GetComponent<Light>().enabled = false; 
			GetComponent<AudioSource>().clip = soundOff; 
			GetComponent<AudioSource>().Play(); 
		} 
	} 
	} 

}
