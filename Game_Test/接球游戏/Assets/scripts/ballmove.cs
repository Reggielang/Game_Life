using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour {

	private Rigidbody rb;
	public float speed2 = 40.0f;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //球掉在板上，给球一个力，让他弹起来
        if (transform.position.y<-10)
        {
			Destroy(gameObject); //销毁游戏对象
			Application.Quit(); //退出游戏
        }
	}

	//碰撞检测
	void OnCollisionEnter(Collision collision) //当球碰到物体时会调用此函数 --只会调用一次
	{
		//当球落在版上施加力，让他弹起来
		rb.AddForce(new Vector3(Random.Range(-0.2f, 0.2f), 1.0f, 0) * speed2);
	}
}
