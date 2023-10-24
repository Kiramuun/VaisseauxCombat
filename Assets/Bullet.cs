using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform _bulletTransform;

    public Rigidbody _bulletRigidbody;

    public float _bulletSpeed;

                 

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void Awake()
    {
        _bulletRigidbody = GetComponent<Rigidbody>();
        _bulletTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        Vector3 velocity = transform.forward* _bulletSpeed;
        Vector3 movementStep = velocity * Time.fixedDeltaTime;
        Vector3 newPos = _bulletTransform.position + movementStep;
        _bulletRigidbody.MovePosition(newPos);
    }

    public void Shoot(float speed)
    {
        _bulletSpeed = speed;
    }
    
}
