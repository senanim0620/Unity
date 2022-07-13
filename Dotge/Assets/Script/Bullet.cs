using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0.1f;

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        transform.Translate(0f, 0f, speed);
        
    }



    // 상대방이 other에 들어오나 본데~!?
    private void OnTriggerEnter(Collider other)
    {
        //?. 연산자 
        //(expression)?. -> : expression 이 null이 아니면 멤버에 접근함
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().Die();
           
        }
    }
}
