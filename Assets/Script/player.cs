using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player:MonoBehaviour
{
    public float MoveSpeed = 0.01f;
    void Start()
    {

    }
    void Update()
    {
        //移動速度の初期化
        Vector3 move = Vector3.zero;

        //前後移動
        if(Input.GetKey(KeyCode.W))
        {
            move.z += MoveSpeed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            move.z += -MoveSpeed;
        }
        // 左右移動
        if (Input.GetKey(KeyCode.D))
        {
            move.x += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.x += -MoveSpeed;
        }
        // 移動させる
        transform.position += move;
    }

}
