using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateRay : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray;
        RaycastHit hit;
        //使用射线分为两步
        //1-创建射线 2-射线检测并反馈结果

        //鼠标点击一个东西反馈给我们物体信息
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //把摄像机屏幕点转化成线
            if (Physics.Raycast(ray,out hit))
            {
                //碰到的物体信息
                //Debug.Log(hit.collider.name);
                GameObject.Destroy(hit.collider.gameObject);
            }
        }


    }
}
