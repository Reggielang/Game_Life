using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copysp : MonoBehaviour {

    public GameObject sp;
	// Use this for initialization
	void Start () {

        //延迟调用只会调用一次
        //Invoke("Copy",2);
        //第一个参数是方法名，第二个参数是延迟几秒调用，第三个参数是等待几秒后调用一次。
        InvokeRepeating("Copy", 1,1);
    }
	


	// Update is called once per frame
	void Update ()
    {
        
	}
    //封装一个方法
    void Copy()
    {
        Vector3 ve3 = new Vector3(0, Random.Range(0, 0.1f), 0);
        Instantiate(sp, ve3, Quaternion.identity);
    }
}
