using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private Rigidbody rigi;
    public float speed = 5f;

	// Use this for initialization
	void Start () {
        rigi = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            rigi.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigi.MovePosition(transform.position + Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigi.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigi.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        print(coll.gameObject.name);
    }
    void OnCollisionStay(Collision coll)
    {
        print(coll.gameObject.name);
    }

    void OnCollisionExit(Collision coll)
    {
        print("离开"+coll.gameObject.name);
    }

}
