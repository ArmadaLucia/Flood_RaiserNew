using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityStandardAssets.CrossPlatformInput;

public class Death : MonoBehaviour{

    public PostProcessingProfile fx;
    public Rigidbody rb;

    private PostProcessingBehaviour camImageFx;

    void Start()
    {

        camImageFx = FindObjectOfType<PostProcessingBehaviour>();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            //red screen
            camImageFx.profile = fx;
            //player stops moving
            rb.isKinematic = true;


        }
    }
}
