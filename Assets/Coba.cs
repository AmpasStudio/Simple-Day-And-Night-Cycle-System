using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coba : MonoBehaviour {
	public float SecondInFullDay = 120f;
	[Range(0,1)]
	public float currentTime = 0;
	[HideInInspector]
	public float timeMultiplier = 1f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		currentTime += (Time.deltaTime/SecondInFullDay)*timeMultiplier;
		if (currentTime >= 1) {
			currentTime = 0;
		}
	}
}
