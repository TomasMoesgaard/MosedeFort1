using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class speakerScript : MonoBehaviour {

	private AudioSource as1;
	private AudioClip currentClip;
	private static List<AudioClip> clipList = new List<AudioClip>();
	private float startTime;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	public AudioClip clip4;
	private int counter = 0;
	public static bool checkPlay = true;
	public static bool delete = false;


	void Start () {

		startTime = Time.time;
		clipList.Add (clip1);
		clipList.Add (clip2);
		clipList.Add (clip3);
		clipList.Add (clip4);
		currentClip = clipList [counter];
		PlaySound (currentClip, 0.8);
	}

	void PlaySound(AudioClip clip, double vol){
		GetComponent<AudioSource>().clip = clip;
		GetComponent<AudioSource>().volume = (float)vol;
		GetComponent<AudioSource>().Play ();
	}

	public bool isPlaying(){
		if(counter < clipList.Count && (Time.time - startTime) >= clipList[counter].length){
			checkPlay = false;
			return false;
		}
		else{
			return true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(!isPlaying()){
		


			if(counter == 1){
				tutorialScript.string1 = "painting";
				tutorialScript.string2 = "cigar";
			}
			if(tutorialScript.next && CutOff.activated && counter < clipList.Count -1){
				counter++;
				startTime = Time.time;
				currentClip = clipList[counter];
				PlaySound(currentClip,0.8);
				delete = true;
			}
			if(tutorialScript.repeat && CutOff.activated){
				startTime = Time.time;
				PlaySound(clipList[counter], 0.8);
			}
		}
		if(isPlaying()){
	

			checkPlay = true;
		}
		if(counter == clipList.Count -1 && !isPlaying()){
			Application.LoadLevel("Implicit");
		}
	}
}
