using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Animator))]  

//Name of class must be name of file as well

public class AnimationScript : MonoBehaviour {



	public List<GameObject> waypoints = new List<GameObject>();

	private List<Renderer> renderers = new List<Renderer>();
	
	protected Animator avatar;
	
	private float SpeedDampTime = .25f;	
	private float DirectionDampTime = .25f;	
	private Vector3 TargetPosition;

	private int nextWayPoint = 0;

	public bool alwaysTalking = false;

	public bool patrol = false;

	public bool animate = false;

	private float waitDuration = 0;

	private Vector3 startPosition;

	private Quaternion startRotation;
	
	// Use this for initialization
	void Start () 
	{
		startPosition = this.transform.position;

		startRotation = this.transform.rotation;

		avatar = GetComponent<Animator>();

		renderers.AddRange(GetComponentsInChildren<Renderer>());

		if (waypoints.Count > 0){
		TargetPosition = waypoints[0].transform.position;
			waitDuration = waypoints[0].GetComponent<MotionBehavior>().WaitTime;

		}


	}
	
	void Update () 
	{


			avatar.SetBool("Conversation1", alwaysTalking);
		

		if(avatar && TargetPosition != null && animate)
		{

			if(Vector3.Distance(TargetPosition, avatar.rootPosition) > 5){
			if(waypoints[nextWayPoint].GetComponent<MotionBehavior>().Run){
				avatar.SetFloat("Speed",2,SpeedDampTime, Time.deltaTime);
			}
			else{
				avatar.SetFloat("Speed",1,SpeedDampTime, Time.deltaTime);
			}
			}

				avatar.SetBool("Conversation1", waypoints[nextWayPoint].GetComponent<MotionBehavior>().Conversation1);
				avatar.SetBool("Conversation2", waypoints[nextWayPoint].GetComponent<MotionBehavior>().Conversation2);
				//avatar.SetBool("Load Cannon", waypoints[nextWayPoint].GetComponent<MotionBehavior>().LoadCannon);
				avatar.SetBool("Looking", waypoints[nextWayPoint].GetComponent<MotionBehavior>().Looking);
				avatar.SetBool("Looking2", waypoints[nextWayPoint].GetComponent<MotionBehavior>().Looking2);

				Vector3 curentDir = avatar.rootRotation * Vector3.forward;
				Vector3 wantedDir = (TargetPosition - avatar.rootPosition).normalized;

				
				if(Vector3.Dot(curentDir,wantedDir) > 0)
				{
					avatar.SetFloat("Direction",Vector3.Cross(curentDir,wantedDir).y,DirectionDampTime, Time.deltaTime);
				}
				else
				{
					avatar.SetFloat("Direction", Vector3.Cross(curentDir,wantedDir).y > 0 ? 1 : -1, DirectionDampTime, Time.deltaTime);
				}

			if(Vector3.Distance(TargetPosition, avatar.rootPosition) < 5){

				if(waitDuration >= 0){
					waitDuration -= Time.deltaTime;

					if(!patrol && (nextWayPoint+1) == waypoints.Count){
						waitDuration = 5;

						if(waypoints[nextWayPoint].GetComponent<MotionBehavior>().DisableRenderers){

							foreach(Renderer r in renderers){
								r.enabled = false;
						}
						}
						if(waypoints[nextWayPoint].GetComponent<MotionBehavior>().EnableRenderers){
								
							foreach(Renderer r in renderers){
									r.enabled = true;
								}
					}
					//print (waitDuration);
					
				}
					avatar.SetFloat("Speed",0,SpeedDampTime, Time.deltaTime);

					if(waypoints[nextWayPoint].GetComponent<MotionBehavior>().ReturnToStartPosition){
						animate = false;
						nextWayPoint = 0;
						this.transform.position = startPosition;
						this.transform.rotation = startRotation;
					}
				}
				if(waitDuration < 0){


				
					if (waypoints.Count > 0){
						
						nextWayPoint = (nextWayPoint+1) % waypoints.Count;
						//print ("next point");

						TargetPosition = waypoints[nextWayPoint].transform.position;
						waitDuration = waypoints[nextWayPoint].GetComponent<MotionBehavior>().WaitTime;
					
					}



				}
				}
			}

		}		
	}   		  

