using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    public bool UseSpeed = false;
    
    private PlayerInput _input;
    private Rigidbody _rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
        
        Debug.Log("이건 무브먼트");
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * speed;
        float ySpeed = _input.Y * speed;
        if (UseSpeed)
        {
            _rigidbody.velocity = new Vector3(xSpeed,0f,ySpeed);
        }
        else
        {
        _rigidbody.AddForce(xSpeed, 0, ySpeed);


        }


    }
}
