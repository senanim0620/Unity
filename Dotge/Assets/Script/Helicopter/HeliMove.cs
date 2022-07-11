using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliMove : MonoBehaviour
{
    public int speed;
    public Rigidbody _rigidbody; // 전체
    public GameObject _prop; // 프로펠러

    

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("이건 무브먼트");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) == true)
        {
            _prop.transform.Rotate(0f, 3f, 0f);
            _rigidbody.AddForce(0f, speed, 0f);
          
        }

        if(Input.GetKey(KeyCode.A)==true)
        {
            gameObject.transform.Rotate(0f, -0.1f, 0f);

        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            gameObject.transform.Rotate(0f, 0.1f, 0f);

        }

    }
}
