using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //初始化存储已吃食物数量的值
    private int i = 0;

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

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter");
        //Destory the food
        if(other.gameObject.name == "Food")
        {
            //判断是否接触食物

            //问题来了：为什么i++会执行两次，也就是enter的动作做了2次
            //回答：因为player的collider勾选了，所以触发两次
            //i++
            // if i = 10 --> Game Win!
            i++;
            GameObject.Destroy(other.gameObject);
           
            Debug.Log("Eat "+ i +" Food!");
            if (i == 10)
            {
                Debug.Log("Game Win!");
            }
        }
    }

    //vs注释代码块，先ctrl+k，再ctrl+C；
    //取消注释。先ctrl+k，再Ctrl+U
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("stay");
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("exit");
    //}
}
