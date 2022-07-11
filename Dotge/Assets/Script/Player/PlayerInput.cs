using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public float X { get; private set; }
    public float Y { get; private set; }


    void Update()
    {
        X = Y = 0f;
        // 이전 값을 날리고 기본 값으로 초기화

        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");



    }
}
