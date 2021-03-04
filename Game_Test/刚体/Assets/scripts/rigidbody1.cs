using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody1 : MonoBehaviour {

	private Rigidbody rigi;
	public float speed = 5.0f;
	// Use this for initialization
	void Start()
	{
		rigi = gameObject.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		rigi.MovePosition(transform.position + Vector3.forward * Time.deltaTime * speed);
	}
}
