using UnityEngine;
using System.Collections;

public class APincho : MonoBehaviour {

    PP pared;
    public GameObject P;
    public int estado;

	void Start () {
        pared = P.GetComponent<PP>();
        /* pared.TrampaReady = true;
         pared.negador = 1;*/
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag =="Player") {
            pared.estado = 1;
        }

    }

   /*void OnTriggerEnter(Collider other) {
      Debug.Log("entro colicionador1"+"VALOR trampaR"+ pared.TrampaReady);
        if (other.gameObject.tag == "Player" && pared.TrampaReady) {
            Debug.Log("entro al if");
            pared.TrampaReady = false; //La trampa ya no esta lista para volver a activarse
            pared.trampa(); //se activa la trampa hasta que toque la pared
        }
    }*/
	
}
