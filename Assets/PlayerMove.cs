using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 _movementInput,
            _orientationInput;

    public float _speed;
                 

    
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"),
              vertical = Input.GetAxisRaw("Vertical"),
              mouseX = Input.GetAxis("Mouse X"),
              mouseY = Input.GetAxis("Mouse Y");

        _movementInput = new Vector3(horizontal, 0, vertical).normalized;
        
        _orientationInput = new Vector2(mouseX, mouseY);
    }

    void LateUpdate()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 velocity = _movementInput * _speed;
        _rigidbody.velocity = velocity;

        Quaternion lookRotation = Quaternion.LookRotation(_orientationInput);
        _rigidbody.MoveRotation(lookRotation);
    }

    private Transform _transform;
    private Rigidbody _rigidbody;
}
