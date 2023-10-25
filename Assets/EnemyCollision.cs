using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int PdV;
    public AudioSource _audioSource;
    public GameObject _particleExplosion;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.CompareTag("Player");
        Debug.Log("Le Joueur ma toucher");

        if (collision.gameObject.CompareTag("Bullet"))
        {
            _audioSource.Play();
            PdV--;
            if (PdV == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
