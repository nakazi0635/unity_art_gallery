using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// WASDキーで移動しQEキーで回転するプレイヤークラス
public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0.005f; // 移動速度変数
    [SerializeField]
    float rotateSpeed = 0.5f; // 回転速度変数

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // Wキーが押されたら
        {
            transform.position += transform.forward * moveSpeed; // z軸位置を加算
        }
        if (Input.GetKey(KeyCode.Q)) // Qキーが押されたら
        {
            transform.Rotate(0, -1 * rotateSpeed, 0); // y軸に回転(右回転)
        }
        if (Input.GetKey(KeyCode.S)) // Sキーが押されたら
        {
            transform.position -= transform.forward * moveSpeed; // z軸位置を減算
        }
        if (Input.GetKey(KeyCode.E)) // Eキーが押されたら
        {
            transform.Rotate(0, 1 * rotateSpeed, 0); // y軸に回転(左回転)
        }
        if (Input.GetKey(KeyCode.A)) // Aキーが押されたら
        {
            transform.position -= transform.right * moveSpeed; // x軸位置を減算
        }
        if (Input.GetKey(KeyCode.D)) // Dキーが押されたら
        {
            transform.position += transform.right * moveSpeed; // x軸位置を加算
        }
    }
}
