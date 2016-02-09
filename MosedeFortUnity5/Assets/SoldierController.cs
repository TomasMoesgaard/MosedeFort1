using UnityEngine;
using System.Collections;

public class SoldierController : MonoBehaviour {

    public GameObject[] path;
    private int currentWaypoint = 0;

    public bool Patrol = false;

    private NavMeshAgent nAgent;

    private Animator anim;

    private float speed = 0f;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();

        nAgent = GetComponent<NavMeshAgent>();

        if (Patrol)
        {
            nAgent.SetDestination(path[0].transform.position);
        }


    }
	
	// Update is called once per frame
	void Update () {

        if(nAgent.remainingDistance > 2f)
        {
            anim.SetFloat("Speed", 1f);
        }
        else
        {
            anim.SetFloat("Speed", 0f);
        }

      

        if(Patrol && nAgent.remainingDistance < 2f)
        {
            currentWaypoint++;
            if(currentWaypoint == path.Length)
            {
                currentWaypoint = 0;
            }

            nAgent.SetDestination(path[currentWaypoint].transform.position);
        }
	
	}


}
