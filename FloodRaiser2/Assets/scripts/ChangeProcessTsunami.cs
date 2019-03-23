using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class ChangeProcessTsunami : MonoBehaviour
{

    public PostProcessingProfile normal, fx;
    public Rigidbody rb;

    private PostProcessingBehaviour camImageFx;

    // Use this for initialization
    void Start()
    {

        camImageFx = FindObjectOfType<PostProcessingBehaviour>();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            camImageFx.profile = fx;
            //player stops moving
            rb.isKinematic = true;
        }

    }
}