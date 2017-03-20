using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //初始化一个rigidbody
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        //获取组件
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontial_move = Input.GetAxis("Horizontal");
        //返回值为1和-1      

        float vertical_move = Input.GetAxis("Vertical"); 
        //为刚体添加一个力AddForce
        rb.AddForce(new Vector3(horizontial_move*10, 0, vertical_move*10));

    }
}
