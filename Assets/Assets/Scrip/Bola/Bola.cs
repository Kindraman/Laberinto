using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour
{

    private Rigidbody rb;
    public int vel1, vel2;
    private int cont;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

        cont = 0;
    }


    public void bolita1()
    {
        rb.AddForce(0f, -10f, vel1);
        Debug.Log("Dentroggg");
    }
    void FixedUpdate()
    {
        if(cont>0)
        rb.AddForce(0f, 0f, vel2 * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        
       if (col.collider.tag == "Suelo" && cont == 0)
        {
            cont++;
        }
        else if (col.collider.tag == "Plataformas" || col.collider.tag == "Pilares")
        {
            Debug.Log("Dentro");
            Destroy(col.gameObject);
        }
    }
}

    

