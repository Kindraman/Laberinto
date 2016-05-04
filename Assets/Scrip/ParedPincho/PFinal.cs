using UnityEngine;
using System.Collections;

public class PFinal : MonoBehaviour {

    PP pared;
    public GameObject P;
    public int estado;

    void Start()
    {
        pared = P.GetComponent<PP>();
  
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Pared1")
        {
            pared.estado = 2;
        }

    }
}
