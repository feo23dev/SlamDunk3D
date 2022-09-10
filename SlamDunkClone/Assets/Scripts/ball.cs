using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private GameManager _GameManager;
    [SerializeField] private AudioSource ballSound;

    private void OnTriggerEnter(Collider other) 
    {
        
        if(other.CompareTag("basket"))
        {
            _GameManager.Basket(transform.position);        
        }
        else if ( other.CompareTag("altobj"))
        {
            _GameManager.YouLost();
        }
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        ballSound.Play();
        
    }
}
