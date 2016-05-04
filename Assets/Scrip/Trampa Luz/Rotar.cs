using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {

    private bool var;

	void Start () {
        gameObject.SetActive(false);
        var = false;
    }

    public void Invertir() {
        Debug.Log("dentro a invertir");
        gameObject.SetActive(!var);

    }

	
}
