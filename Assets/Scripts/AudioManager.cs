using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceSfx;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

     public void ReproducirSonido(AudioClip clip)
    {

        audioSourceSfx.PlayOneShot(clip);  //Para reproducir una vez


    }







}
