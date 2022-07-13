using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"[onCollisionEnter] Me : { gameObject.name}, other : {collision.gameObject.name}");
      //  if (collision.collider.CompareTag("Player"))
           // Debug.Log("����");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[onCollisionStay] Me : { gameObject.name}, other : {collision.gameObject.name}");
       // if (collision.collider.CompareTag("Player"))
          //  Debug.Log("������");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"[onCollisionExit] Me : { gameObject.name}, other : {collision.gameObject.name}");
       // if (collision.collider.CompareTag("Player"))
           // Debug.Log("�ƿ�");
    }

    private void OntriggerEnter(Collider other)
    {
        if (other.CompareTag( "Player"))
           Debug.Log("�÷��̾�� �浹��");
    }


}
