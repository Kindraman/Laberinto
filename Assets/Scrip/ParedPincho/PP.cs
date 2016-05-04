using UnityEngine;
using System.Collections;
using System;

public class PP : MonoBehaviour {

    private Rigidbody rb;
    public int Fuerza;
    public GameObject Pincho;
    private APincho pinchi;
    public int estado;

    //public int negador; //atributo que se encarga de invertir el movimiento
    //public bool TrampaReady; //que que define si la trampa esta lista para volver a ser ejecutada (inversamente)

    void Start () {
        rb = GetComponent<Rigidbody>();
        pinchi = Pincho.GetComponent<APincho>();
    }

    void Update() {
        if (estado==1) {
            rb.AddForce(new Vector3(Fuerza, 0, 0) * Time.deltaTime);
        }
        if (estado == 2)
        {
            rb.AddForce(new Vector3(-Fuerza, 0, 0) * Time.deltaTime);
        }

    }


   /* void OnTriggerEnter(Collider col) {
       if (col.gameObject.tag == "Pared1")
        {
            this.TrampaReady = true; // La trampa vuelva a estar lista
            this.negador = -(this.negador); //cuando vuelve a estar lista la trampa el negador se invierte para darle direccion contraria..
        }
    }
    public void trampa() {
        while (!TrampaReady) { // Mientras la trampa no este lista
            Debug.Log("Entro al whilesiño   " + TrampaReady);

            rb.AddForce(new Vector3(Fuerza, 0, 0) * Time.deltaTime * negador); //Aqui negador hace el juego de la direccion del movimiento
        }*/
        
    }
    

/*
    public void Aplastar(){
        rb.AddForce(new Vector3(Fuerza, 0, 0)*Time.deltaTime);
        
        }
    public void Devolver()
    {
        rb.AddForce(new Vector3(-Fuerza, 0, 0) * Time.deltaTime);

    }*/
