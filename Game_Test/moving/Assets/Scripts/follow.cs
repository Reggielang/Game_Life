using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	//把摄像机相对于物体的距离写死


	private Vector3 offset;
	
	public GameObject player;//我们要跟随的物体

	// Use this for initialization
	void Start () {
		//计算摄像机和要跟随物体之间的距离
		offset = player.transform.position - transform.position;
		//因为距离被写死了，所以中间距离不会变化
	}
	
	// Update is called once per frame
	void Update () {
		//现在要确定自身的位置，用跟随物体的坐标-中间距离
		transform.position = player.transform.position - offset;
	}
}
