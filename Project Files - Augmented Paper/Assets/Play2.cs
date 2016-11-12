using UnityEngine;
using System.Collections;

public class Play2 : MonoBehaviour {

	void Start () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play ();

	}
}
