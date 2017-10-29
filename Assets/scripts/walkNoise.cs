using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkNoise : MonoBehaviour {
	private Rigidbody rb;
	private AudioSource audio;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity.magnitude > 1 && !audio.isPlaying) {
			audio.Play ();
		}
	}
}
