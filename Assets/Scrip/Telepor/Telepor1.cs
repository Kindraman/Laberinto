using UnityEngine;
using System.Collections;


public class Telepor1 : MonoBehaviour {

    public Transform Player;
    public Transform PosicionTP;

	void Start () {
	    Player = GameObject.FindGameObjectWithTag("Player").transform;
        PosicionTP = GameObject.FindGameObjectWithTag("PosicionTP").transform;
    }
	

	void Update () {
        transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
	}

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag=="Player" ) {
            Player.position = PosicionTP.position;
        }
    }


}
