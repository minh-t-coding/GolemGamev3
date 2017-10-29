using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScript : MonoBehaviour {

	[SerializeField]
	public string LevelName;

	public void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Player")) {
			Application.LoadLevel(LevelName);
		}


	}

}
