using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voicehelp : MonoBehaviour {

 public AudioClip Narrator;
    private AudioSource audio { get { return GetComponent<AudioSource>(); } }

	// Use this for initialization
	void Start () {
        gameObject.AddComponent<AudioSource>();
        //adds source

	}
	
	// Update is called once per frame
	void Update () {
		

        if(GazeExplosion.instance.Counting()==1)
        {
            audio.clip = Narrator;
            audio.Play();


        }
	}
}
