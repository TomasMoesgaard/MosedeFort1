using UnityEngine;
using System.Collections;

public class LookHandler : MonoBehaviour {

    private GameObject target;

    public static bool EVENT_ONGOING = false;

    private float lookTimer = 0f;

    private float rayTimer = 0f;

    public GameObject LoadingBar;

	// Use this for initialization
	void Start () {

      //  Cursor.visible = false;
      //  Cursor.lockState = CursorLockMode.Confined;

    }
	
	// Update is called once per frame
	void Update () {

        LoadingBar.GetComponent<Renderer>().material.SetFloat("_Cutoff", Mathf.InverseLerp(1.98f, 0f, lookTimer) + 0.02f);


        if (EVENT_ONGOING)
        {
            if (target && target.GetComponent<Interactable>())
            {
                target.GetComponent<Interactable>().ShaderStandard();
            }
            target = null;

            lookTimer = 0f;
        }
        else
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();

            }

            if (Time.time > rayTimer)
            {
                rayTimer = Time.time + 0.02f;

                // Debug.Log("Cast!");

                RaycastHit hit;

                if (Physics.Raycast(transform.position, transform.forward, out hit))
                {
                    if (hit.collider.GetComponent<Interactable>())
                    {

                        if (target && hit.collider.name != target.name)
                        {
                            target.GetComponent<Interactable>().ShaderStandard();
                        }
                        target = hit.collider.gameObject;
                        //  Debug.Log(target.name);
                    }
                    else
                    {
                        if (target && target.GetComponent<Interactable>())
                        {
                            target.GetComponent<Interactable>().ShaderStandard();
                        }
                        target = null;

                        lookTimer = 0f;
                    }

                }
                else
                {
                    if (target && target.GetComponent<Interactable>())
                    {
                        target.GetComponent<Interactable>().ShaderStandard();
                    }
                    target = null;

                    lookTimer = 0f;
                }

            }

            if (target)
            {
                target.GetComponent<Interactable>().ShaderUnlit();

                lookTimer += Time.deltaTime;

               // Debug.Log(lookTimer);
            }

            if (lookTimer > 2f)
            {

                LookHandler.EVENT_ONGOING = true;

                target.GetComponent<Interactable>().ActivateEvent();

            }
        }
	}


}
