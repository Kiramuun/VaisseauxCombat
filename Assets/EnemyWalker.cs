using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    public Transform _playerTransform,
                     _enemyTransform;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void Awake()
    {
        transform.position = GetComponent<Transform>().position;
    }

    void FixedUpdate()
    {
        TurnTowardsPlayer();
    }

    void TurnTowardsPlayer()
    {
        Vector3 dir = _playerTransform.forward;
        Quaternion dirRotate = Quaternion.LookRotation(dir, Vector3.up);
        Quaternion Rotate = Quaternion.RotateTowards(transform.rotation, dirRotate, 0.5f);

        _enemyTransform.rotation = Rotate;
    }
}
