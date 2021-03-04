using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody2 : MonoBehaviour
{

	private Rigidbody rigi;
	public float force = 1.0f;
	// Use this for initialization
	void Start()
	{
		rigi = gameObject.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		//施加力给刚体
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		rigi.AddForce(new Vector3(h, 0, v) * force);
	}
}