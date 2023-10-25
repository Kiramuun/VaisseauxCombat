using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject _bulletPrefab;
    public AudioSource _audioSource;
    public Transform _cannon,
                     _groupBullets;
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
        bool pressButton = Input.GetButtonDown("Shoot");
        if (pressButton) { if (Time.time > _nextShotTime) { FireBullet(); } }
        if (pressButton) { _audioSource.Play(); }
    }

    void FireBullet()
    {
        
        GameObject newBullet = Instantiate(_bulletPrefab, _cannon.transform);
        newBullet.transform.parent = _groupBullets;
        Bullet b = newBullet.GetComponent<Bullet>();
        b.Shoot(_bulletSpeed);
    }
}
