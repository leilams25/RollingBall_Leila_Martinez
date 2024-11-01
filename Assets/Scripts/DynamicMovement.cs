using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad;
    [SerializeField] float h;
    [SerializeField] float v;
    public bool queEsSuelo;

    public float Velocidad { get => velocidad; set => velocidad = value; }
    public float H { get => h; set => h = value; }

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        queEsSuelo = false;

    }


    void Update()
    {


        H = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");


        if (Input.GetKeyDown(KeyCode.Space))

        {

            rb.AddForce(new Vector3(0, 10 ,0 ).normalized * 5, ForceMode.Impulse);


        }






    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(H, 0, v).normalized * Velocidad, ForceMode.Force );


    }


   public void EstoyCayendo()
    {

        if (queEsSuelo == false)
        {
            

        }


    }
}

