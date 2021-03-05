using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scle : MonoBehaviour {

    public float speed = 5.0f;
    private float y;
    private float x;
    private float z;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            y = transform.localScale.y * speed * Time.deltaTime;
        }
        x = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.localScale += new Vector3(x, y, z); //把变化过的X,Y,Z轴重新赋值给当前物体
    }
}
