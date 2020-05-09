using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class v_button_execution : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbutton;
    public GameObject sidious_holo;
    public GameObject holo_light;
    public AudioSource sidious_audio;
    public Renderer holo_mat;
    public Material Material1;
    public Material Material2;
    // Start is called before the first frame update
    void Start()
    {
        vbutton = GameObject.Find("holo_button");
        vbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        sidious_audio.GetComponent<AudioSource>();
        sidious_holo.GetComponent<GameObject>();
        holo_light.GetComponent<GameObject>();
        sidious_holo.SetActive(false);
        holo_light.SetActive(false);
        holo_mat.GetComponent<MeshRenderer>().material = Material1;


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sidious_holo.SetActive(true);
        holo_light.SetActive(true);
        sidious_audio.Play();
        holo_mat.GetComponent<MeshRenderer>().material = Material2;
    }
    
    

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("GG");
    }
    // Update is called once per frame
    void Update()
    {
        if (sidious_audio.isPlaying == false)
        {
            sidious_holo.SetActive(false);
            holo_light.SetActive(false);
            holo_mat.GetComponent<MeshRenderer>().material = Material1;
        }
    }
}
