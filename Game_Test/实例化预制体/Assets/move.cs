using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private Rigidbody ri;
    public float speed = 5.0f;
    public float num = 0.1f;
	// Use this for initialization
	void Start () {
        ri = this.GetComponent<Rigidbody>();

        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            ri.MovePosition(transform.position +Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ri.MovePosition(transform.position + Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ri.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ri.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
        
    }
    
    void OnCollisionEnter(Collision coll)//coll--代表被碰撞的物体
    {
        if (coll.gameObject.tag=="Ball") //tag--表明碰到的物体是谁
        {

            Destroy(coll.gameObject);
            //练习:每销毁一个球，就自身变大
            num = transform.localScale.x * num;

            transform.localScale += new Vector3(0, 0, num); //把变化过的X,Y,Z轴重新赋值给当前物体
            
            //练习2：每销毁一个球，就增加一个球。
            Vector3 ve3 = new Vector3(Random.Range(-5.0f, 5.0f), 2.0f, Random.Range(-5.0f, 5.0f));
            Instantiate(coll.gameObject, ve3, Quaternion.identity);

                //第一个参数代表实例化物体
                //第二个参数代表实例化物体的位置
                //第三个参数代表实例化物体的旋转角度 --Quaternion.identity无旋转
        }     
    }


}
