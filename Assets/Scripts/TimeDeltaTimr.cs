using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TimeDeltaTimr : MonoBehaviour
{
    [SerializeField]  Vector3 direccion;
    
    float timer = 0f * Time.deltaTime;
    [SerializeField] float velocidad;
    void Start()
    {
        

    }

    
    void Update()
    {


        timer += 1 * Time.deltaTime;
        Debug.Log(timer);

        if (timer <= 5f)
        {
            transform.Translate(direccion * velocidad * Time.deltaTime);


        }
        else if (timer > 5 & timer <= 10f)
        {


            transform.Translate(-direccion * velocidad * Time.deltaTime);
            

           


        }
        if (timer >= 10f)
        {
            timer = 0;



        }








    }
}
