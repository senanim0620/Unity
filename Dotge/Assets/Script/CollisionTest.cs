using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"[onCollisionEnter] Me : { gameObject.name}, other : {collision.gameObject.name}");
      //  if (collision.collider.CompareTag("Player"))
           // Debug.Log("엔터");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[onCollisionStay] Me : { gameObject.name}, other : {collision.gameObject.name}");
       // if (collision.collider.CompareTag("Player"))
          //  Debug.Log("스테이");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"[onCollisionExit] Me : { gameObject.name}, other : {collision.gameObject.name}");
       // if (collision.collider.CompareTag("Player"))
           // Debug.Log("아웃");
    }

    private void OntriggerEnter(Collider other)
    {
        if (other.CompareTag( "Player"))
           Debug.Log("플레이어와 충돌함");
    }


}
