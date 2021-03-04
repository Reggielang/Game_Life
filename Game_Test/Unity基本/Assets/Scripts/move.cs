using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public Transform tr;

	// Use this for initialization
	void Start()
	{
		//Debug.Log("你在干什么？");
		tr = gameObject.GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{
		//Debug.Log("每帧调用");
		print(tr.transform.position);
	}
}
