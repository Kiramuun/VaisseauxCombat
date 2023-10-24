using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject _bulletPrefab;

    public Transform _cannon;
    public float _bulletSpeed,
                 _delayBetweenShots;
    float _nextShotTime;

    void Start()
    {
        
    }

    void Awake()
    {
        _nextShotTime = Time.time;
    }

    void Update()
    {
        if (Time.time >= _nextShotTime) { FireBullet(); }
        if (Input.GetButtonDown("Shoot")) { FireBullet(); }
        //FireBullet();
    }

    void FireBullet()
    {
        
        GameObject newBullet = Instantiate(_bulletPrefab, _cannon.transform);
        Bullet b = newBullet.GetComponent<Bullet>();
        b.Shoot(_bulletSpeed);

    }
}
