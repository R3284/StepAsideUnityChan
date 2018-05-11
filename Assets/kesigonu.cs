using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kesigonu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("aaaaaaaaaaa");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log(other.gameObject.name);
		Destroy (other.gameObject);
	}
}
