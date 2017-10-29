using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour {
	public void Trans(string scenename)
	{
		StartCoroutine(ChangeLevel(scenename));
	}

	IEnumerator ChangeLevel (string scenename) {
		float fadeTime = GameObject.Find ("Main Camera").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel (scenename);
	}
}
