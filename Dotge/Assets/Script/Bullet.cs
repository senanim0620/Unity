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



    // ������ other�� ������ ����~!?
    private void OnTriggerEnter(Collider other)
    {
        //?. ������ 
        //(expression)?. -> : expression �� null�� �ƴϸ� ����� ������
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().Die();
           
        }
    }
}
