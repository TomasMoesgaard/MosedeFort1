using UnityEngine;
using System.Collections;

public class TintChange : MonoBehaviour {

	private GameObject ec;

	float duration  = 1.0f;

	public int range = 15;

	public GameObject go;

	private Control control;

	void Start (){

		ec = GameObject.Find("ExplicitController");

		control = go.GetComponent<Control>();

	}


	void Update ()
	{

		if(ec.GetComponent<EControl>().ExplicitOn){
			float lerp = Mathf.PingPong (Time.time, duration) / duration;
			GetComponent<Light>().range = lerp * range;
		}
		else if(control != null)
		{
			GetComponent<Light>().range = 0;
		}
		if(control != null){
			if(control.HasPlayed)
				Destroy(gameObject);
		}
	}
}
