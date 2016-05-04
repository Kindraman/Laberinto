using UnityEngine;
using System.Collections;

public class ActivadorFantasma : MonoBehaviour {


    Fantasma fanti;
    public GameObject FM;
    void Start()
    {

        fanti = FM.GetComponent<Fantasma>();

    }


    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.tag == "Player")
        {
            fanti.fanti1();
        }
    }
}
