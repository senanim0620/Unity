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
        // ���� ���� ������ �⺻ ������ �ʱ�ȭ

        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");



    }
}
