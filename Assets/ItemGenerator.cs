using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
	public GameObject applePrefab;
	public GameObject bombPrefab;
	float span = 1.0f;
	float delta = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
		if(this.delta > this.span)
		{
			this.delta = 0.0f;
			Instantiate(applePrefab);
		}
	}
}
