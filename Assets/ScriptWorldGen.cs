using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptWorldGen : MonoBehaviour {

	public GameObject starPrefab;
	public List<GameObject> starList; //List of all existing stars
	Quaternion quat;

	// Use this for initialization
	void Start () {
		starList = new List<GameObject>();
		float x;
		float y;

		for (int i = 0; i < 5; i++) {
			x = Random.value * 10 - 5;
			y = Random.value * 10 - 5;
			Instantiate (starPrefab, new Vector2 (x, y), quat);
		}

		//Vector2.Distance();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
