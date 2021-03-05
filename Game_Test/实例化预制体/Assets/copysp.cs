using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copysp : MonoBehaviour {

    public GameObject sp;
	// Use this for initialization
	void Start () {
        //实例化预制体
        for (int i = 0; i < 10; i++)
        {
            Vector3 ve3 = new Vector3(Random.Range(-5.0f,5.0f),2.0f, Random.Range(-5.0f, 5.0f));
            Instantiate(sp, ve3, Quaternion.identity);

            //第一个参数代表实例化物体
            //第二个参数代表实例化物体的位置
            //第三个参数代表实例化物体的旋转角度 --Quaternion.identity无旋转
        }
    }
	


	// Update is called once per frame
	void Update ()
    {
        
	}
}
