using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 _movementInput,
            _orientationInput;

    public float _speed,
                 smooth = 5.0f,
                 tiltAngle = 60.0f;

    
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
              tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle,
              tiltAroundX = Input.GetAxis("Vertical") * tiltAngle,
              mouseX = Input.GetAxis("Mouse X"),
              mouseY = Input.GetAxis("Mouse Y");

        _movementInput = new Vector3(horizontal, 0, vertical).normalized;
        
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundZ,0 );
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
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
