using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    //创建需要跟随的游戏组件
    public GameObject player;  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //获取游戏组件的初始位置
       Vector3 player_position =  player.GetComponent<Transform>().position;
        //更新位置
        this.GetComponent<Transform>().position = new Vector3(player_position.x, player_position.y + 4.19f,player_position
            .z-4.07f);
	}
}
