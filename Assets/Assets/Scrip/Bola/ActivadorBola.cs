using UnityEngine;
using System.Collections;

public class ActivadorBola : MonoBehaviour {
    Bola bola;
    public GameObject BM;
   void Start()
    {

        bola = BM.GetComponent<Bola>();

    }
    

    void OnTriggerEnter(Collider otro) {
        if (otro.gameObject.tag == "Player") {
            bola.bolita1();
        }
    }
	

	
}
