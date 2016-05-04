using UnityEngine;
using System.Collections;

public class Fantasma : MonoBehaviour {

    public NavMeshAgent nav;

	void Start () {
        nav = GetComponent<NavMeshAgent>();
        nav.gameObject.SetActive(false);
	}

    public void fanti1() {
        nav.gameObject.SetActive(true);

    }

	
}
