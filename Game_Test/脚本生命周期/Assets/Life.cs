using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

    private Rigidbody ri;
    //Awake仅调用一次，优先级在Start上
    void Awake() {
        print("Awake01");
    }
    // Use this for initialization
    void Start() {
        print("Start02");
        ri = this.GetComponent<Rigidbody>();
    }
    //固定的0.02秒固定调用一次--多用于物理函数
    void FixedUpdate()
    {
        ri.AddForce(Vector3.up);
        print("FixedUpdate06");
    }

    // Update is called once per frame
    void Update() {
        print("Update03");
    }

    //在Update之后执行，用于摄像机跟随/脚本执行顺序等
    void LateUpdate()
    {
        print("LateUpdate07");
    }

    //控制脚本的启用与关闭
    void OnEnable()
    {
        print("OnEnable04");

    }
    void OnDisable()
    {
        print("OnDisable05");

    }
    //OnGUI用于界面显示一些血条，按钮等。


}
