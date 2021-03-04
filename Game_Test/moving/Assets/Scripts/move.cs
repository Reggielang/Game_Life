using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	private Transform t_transform;

	public float speed = 0.5f; 
	//改变显示板中的值不会影响代码的值
	// Use this for initialization
	void Start () {
		t_transform = gameObject.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//每帧调用-1秒等于60帧
		//t_transform.Translate(Vector3.forward*speed*Time.deltaTime,Space.World);
		//一秒移动0.5m
		//Time.deltaTime作用：把60帧转化成一秒
		if (Input.GetKey(KeyCode.W)) 
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.Z))
		{
			transform.Translate(Vector3.up * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.X))
		{
			transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
		}





	}
}
