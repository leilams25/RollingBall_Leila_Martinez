using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float velocidad;
    void Start()
    {



       



    }

    
    void Update()
    {
        transform.Translate(1, 0, 0 * velocidad * Time.deltaTime);
    }
}
