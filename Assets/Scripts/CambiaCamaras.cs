using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamaras : MonoBehaviour
{
    // REFERENCIAS A LAS DOS CAMARAS COMO TIPO GAME OBJECT
    // CUANDO NOS ATRAVIESE EL JUGADOR
    // DESACTIVAR UNA CAMARA Y ACTIVAR LA OTRA gO.SetActive(true/false)

    [SerializeField] GameObject camara1;
    [SerializeField] GameObject camara2;



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

            if (camara1.activeSelf)
            {

                camara1.SetActive(false);
                camara2.SetActive(true);
            }
            else
            {

                camara1.SetActive(true);
                camara2.SetActive(false);
            }

        }
        



    }

}
