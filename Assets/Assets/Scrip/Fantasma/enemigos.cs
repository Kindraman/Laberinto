using UnityEngine;
using System.Collections;

public class enemigos : MonoBehaviour {
    public float DistanciaMuerte= 0.5f;
    public float DistanciaSeparacion;
    public Transform esteobjeto;
    public Transform target;
    private NavMeshAgent NavComponent;


	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        NavComponent = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	
	void Update () {
        float distancia = Vector3.Distance(target.position, transform.position);

        if (target)
        {
            NavComponent.SetDestination(target.position);
        }
        else {
            if (target == null)
            {
                target = this.gameObject.GetComponent<Transform>();

            }
            else {
                target = GameObject.FindGameObjectWithTag("Player").transform;
            }
        }
	}
}
