using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    [SerializeField] private AudioSource audioClip;
    private AudioManager manager;   
    void Start()
    {
        
    }

   
    void Update()
    {
        
 
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //manager.ReproducirSonido(audioClip);

        }


    }









}
