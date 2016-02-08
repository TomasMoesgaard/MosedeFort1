using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {

    Renderer renderer;

    Renderer[] renderers;

    private Shader shader1;
    private Shader shader2;

    private bool shaderUnlit = false;

    public AudioSource Audio;

    public GameObject[] Soldiers;

    public Animator Animator;

    // Use this for initialization
    void Start () {

        shader1 = Shader.Find("Standard");
        shader2 = Shader.Find("Unlit/Texture");

        renderer = GetComponent<Renderer>();

        renderers = GetComponentsInChildren<Renderer>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShaderUnlit()
    {
        //renderer.material.shader = shader2;


        if (!shaderUnlit)
        {
            foreach (Renderer r in renderers)
            {
                r.material.shader = shader2;
            }
        }
        shaderUnlit = true;
    }

    public void ShaderStandard()
    {

      
        if (shaderUnlit)
        {
            foreach (Renderer r in renderers)
            {
                r.material.shader = shader1;
            }
        }
        shaderUnlit = false;
    }
}
