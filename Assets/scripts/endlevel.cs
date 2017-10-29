using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlevel : MonoBehaviour {
	//[SerializeField]
	//public string nextName;
	//public GameObject crate;
	//[SerializeField]
	//public string levelName;
	//[SerializeField]
	//public 
	[SerializeField]
	public string LevelName;


	//void OnTriggerEnter(Collider other){
	//	if (other.CompareTag("nextLevel")) {
	//		//Transition.Trans (nextName);
	//		GameObject.Find ("Main Camera").Transition.Trans(nextName);
	//	}
	//}

	public void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			Application.LoadLevel (LevelName);
		}

	}
}
