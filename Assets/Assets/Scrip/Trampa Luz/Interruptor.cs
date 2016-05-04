using UnityEngine;
using System.Collections;

public class Interruptor : MonoBehaviour {
    public GameObject PisoRotable;
    private Rotar R;
    private bool E;
	void Start () {
        R = PisoRotable.GetComponent<Rotar>();

	}
    void    Update() {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //E = true;
            R.Invertir();
        }
       // else {
          //  E = false;
       // }
    }

   /* public void OnTriggerStay(Collider objeto) {

        if (objeto.gameObject.tag == "Player" && E) {
            R.Invertir();
          
        } 
    }*/

	
}
