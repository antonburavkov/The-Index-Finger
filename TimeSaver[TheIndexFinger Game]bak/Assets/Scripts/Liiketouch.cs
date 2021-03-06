﻿using UnityEngine;
using System.Collections;

public class Liiketouch : Kosketusviesti {
	
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 hups;
	public Vector3 liikkuu;
	public Vector3 liikkuuhoriz;
	bool hyppy = false;
	bool liikuvasen = false;
	bool liikuoikea = false;
	public float maksiminopeus = 5f;
	
	
	// Use this for initialization
	void Start () {
		
	}
	public void Update()
	{
		if (Kosketusviesti.hypataan == 1) 
		{
			hyppy = true;
		}
		if (Kosketusviesti.hypataan == 0) 
		{
			hyppy = false;
		}
		if (Kosketusviesti.vasen == 1) 
		{
			liikuvasen = true;		
		}
		if (Kosketusviesti.oikea == 1) 
		{
			liikuoikea = true;		
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		velocity += gravity * Time.deltaTime;
		velocity += liikkuu * Time.deltaTime;
		if (hyppy == true) 
		{
			velocity.y += hups.y;
		}
		if (hyppy = false)
		{
			velocity.y -= hups.y;
			velocity.x += 1f;
			
		}
		if (liikuvasen == true) 
		{
			liikuvasen = false;
			velocity.z += liikkuuhoriz.z;
		}
		if (liikuoikea == true) 
		{
			liikuoikea = false;
			velocity.z -= liikkuuhoriz.z;
		}
		velocity = Vector3.ClampMagnitude (velocity, maksiminopeus);
		
		transform.position += velocity * Time.deltaTime;
	}
}