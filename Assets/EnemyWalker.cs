using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    public Transform _playerTransform;

    /*public float _*/

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    void TurnTowardsPlayer()
    {

    }

    private Transform _transform;
}
