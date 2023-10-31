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

    void Awake()
    {
        _nextShotTime = Time.time;
    }

    void Start()
    {
        
    }

    void Update()
    {
        bool pressButton = Input.GetButton("Shoot");
        if (pressButton)
        {
            if (Time.time >= _nextShotTime) { FireBullet(); } 
        }
    }

    void FireBullet()
    {
        GameObject newBullet = Instantiate(_bulletPrefab, _cannon.transform);
        newBullet.transform.parent = _groupBullets;
        Bullet b = newBullet.GetComponent<Bullet>();
        b.Shoot(_bulletSpeed);
        _nextShotTime = Time.time + _delayBetweenShots;
        _audioSource.Play();
    }
}
