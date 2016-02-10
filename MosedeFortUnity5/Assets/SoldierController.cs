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


        nAgent.updatePosition = false;

        if (Patrol)
        {
            StartCoroutine(GoToWaypoint());
        }


    }
	
	// Update is called once per frame
	void Update () {


       // Debug.Log(nAgent.velocity);

       // anim.SetFloat("Direction", nAgent.velocity)

	}

    public void StartPath()
    {

        StartCoroutine(GoToWaypoint());
    
    }

    IEnumerator GoToWaypoint()
    {

        if (path[currentWaypoint].GetComponent<MotionBehavior>().Run == true)
        {
            anim.SetFloat("Speed", 2f);
            nAgent.speed = 23f;
        }
        else
        {
            anim.SetFloat("Speed", 1f);
            nAgent.speed = 8f;
        }

        nAgent.SetDestination(path[currentWaypoint].transform.position);

        yield return new WaitWhile(() => nAgent.pathPending);

        anim.SetBool("Conversation1", path[currentWaypoint].GetComponent<MotionBehavior>().Conversation1);
        anim.SetBool("Conversation2", path[currentWaypoint].GetComponent<MotionBehavior>().Conversation2);
        anim.SetBool("Looking", path[currentWaypoint].GetComponent<MotionBehavior>().Looking);
        anim.SetBool("Looking2", path[currentWaypoint].GetComponent<MotionBehavior>().Looking2);



            yield return new WaitUntil(() => nAgent.remainingDistance < 0.5f);

        
        
            anim.SetFloat("Speed", 0f);

        if(!Patrol)
        Debug.Log("Speed set to 0");

        // nAgent.Stop();

        if (path[currentWaypoint].GetComponent<MotionBehavior>().WaitForEventEnd)
        {
            yield return new WaitWhile(() => LookHandler.EVENT_ONGOING);
        }

            yield return new WaitForSeconds(path[currentWaypoint].GetComponent<MotionBehavior>().WaitTime);

            currentWaypoint += 1;

        //Debug.Log("Waypoint incremented to: " + currentWaypoint);

            if (Patrol && path.Length == currentWaypoint)
            {
           // Debug.Log("Here1");
                currentWaypoint = 0;
                StartCoroutine(GoToWaypoint());
            }
            else if (currentWaypoint < path.Length)
            {
          //  Debug.Log("Here2");
            StartCoroutine(GoToWaypoint());
            }

        
    }

    void OnAnimatorMove()
    {
        // Update position to agent position
        transform.position = nAgent.nextPosition;
    }



}
