using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBrick : MonoBehaviour {

    public GameObject Brick;
    public GameObject Blt;
	// Use this for initialization
	void Start () {
        //随机在场景中实例化砖块
        for (int i = 0; i < 10; i++)
        {
            Vector3 ve3 = new Vector3(Random.Range(-8, 8), 0.6f, Random.Range(-7, 8));
            GameObject.Instantiate(Brick, ve3, Quaternion.identity);
        }
        
	}

    // Update is called once per frame
    void Update()
    {
        Ray ray;
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("射线");
            if (Physics.Raycast(ray, out hit))
            {
                //实例化子弹
                GameObject bt = GameObject.Instantiate(Blt, transform.position, Quaternion.identity);
                //找出方向让子弹发射
                //鼠标点击位置-我们摄像机的位置得出一个方向
                //向量代表方向
                Vector3 dis = hit.point - transform.position;
                bt.GetComponent<Rigidbody>().AddForce(dis * 300);
            }
        }
    }
}
