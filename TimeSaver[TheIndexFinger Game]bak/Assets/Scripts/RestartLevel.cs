﻿using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Move.death == 1) 
		{
			GetComponent<GUITexture>().enabled = true;
			Time.timeScale = 0;
		}
	}
	public void OnMouseDown()
	{
		Move.death = 0;
		Time.timeScale = 1;
		Application.LoadLevel("androidpeli");

	}
}
