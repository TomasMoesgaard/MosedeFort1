using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour {
/*
	public bool HasPlayed = false;
	public bool LookedAt = false;
	public bool AudioDone = false;

	public bool isplaying = false;

	public GameObject expDetached;

	private AudioSource expAudio;

	//private TBE_3DCore.TBE_Source expAudio2;

	public float activationTimer = 0.0f;

	public Shader shader1;
	public Shader shader2;

	public bool autoReset = false;

	public float autoResetTimerAmount = 0.0f;

	private float autoResetTimer = 0.0f;

	public bool isZeppeliner = false;

	private GameObject count;

	private CounterScript cs;

	public Transform Zeptrans;
	

	private List<Renderer> renderers = new List<Renderer>();

	private List<AnimationScript> anim = new List<AnimationScript>();

	public List<AnimationScript> extAnim = new List<AnimationScript>();

	// Use this for initialization
	void Start () {
		shader1 = Shader.Find("Diffuse");
		shader2 = Shader.Find("Self-Illumin/Diffuse");

		renderers.AddRange(GetComponentsInChildren<Renderer>());

		count = GameObject.Find("Counter");

		anim.AddRange(GetComponentsInChildren<AnimationScript>());

		anim.AddRange(extAnim);

		cs = count.GetComponent<CounterScript>();

		}
	}
	
	// Update is called once per frame
	void Update () {

		if(autoReset && AudioDone){

			autoResetTimer += Time.deltaTime;

			if(autoResetTimer > autoResetTimerAmount){
				HasPlayed = false;
				LookedAt = false;
				AudioDone = false;
				
				isplaying = false;
			}

		}



		if(HasPlayed && !isplaying && !AudioDone){
			//print ("audioDone");
			AudioDone = true;
			cs.foundEvents++;
		}

		//print (name + " " + isplaying);

		//Debug.Log (LookedAt);

			if(HasPlayed){
				activationTimer = 0f;

			if(isZeppeliner){
				Zeptrans.Translate(Time.deltaTime * 70, 0, Time.deltaTime * 40, Space.Self);
			}
			
			foreach(AnimationScript a in anim){
				a.animate = true;
			}
			}

		
			if(LookedAt && activationTimer < 2.0f && !HasPlayed){
				//activationTimer += Time.deltaTime;

			foreach(Renderer r in renderers){
				r.material.shader = shader2;
			}
			}
			else{

			foreach(Renderer r in renderers){
				r.material.shader = shader1;
			}
				if(LookedAt && activationTimer >= 2.0f && !HasPlayed){
				if(expAudio != null){
					expAudio.Play();
					HasPlayed = true;
					isplaying = true;
				}
				else if(expAudio2 != null)
				{
					expAudio2.Play();
					HasPlayed = true;
					isplaying = true;
				}
				else
				{
					GetComponent<AudioSource>().Play();
					HasPlayed = true;
					isplaying = true;
				}
				//HasPlayed = true;
				//cs.FoundOne(transform.name);


			

			}


			if(HasPlayed && expAudio != null){
				//print ("isplaying = " + isplaying);
				isplaying = expAudio.isPlaying;
			}
			else if(HasPlayed && expAudio2 != null){
				isplaying = expAudio2.isPlaying;
			}
			else if(HasPlayed && GetComponent<AudioSource>() != null){
				isplaying = GetComponent<AudioSource>().isPlaying;
			}

		}

	}
    */
	
}