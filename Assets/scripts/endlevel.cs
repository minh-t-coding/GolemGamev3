using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlevel : MonoBehaviour {
	//[SerializeField]
	//public string nextName;
	//public GameObject crate;
	[SerializeField]
	public GameObject buttonthing;
	//[SerializeField]
	//public 


	//void OnTriggerEnter(Collider other){
	//	if (other.CompareTag("nextLevel")) {
	//		//Transition.Trans (nextName);
	//		GameObject.Find ("Main Camera").Transition.Trans(nextName);
	//	}
	//}

	public void OnCollisionEnter(Collider col){
		if (col.CompareTag("Player")) {
			Debug.Log ("in");
			buttonthing.SetActive (true);
		}

	}


}
