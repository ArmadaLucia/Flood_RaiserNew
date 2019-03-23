using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityStandardAssets.CrossPlatformInput;

using UnityStandardAssets.Characters.FirstPerson;

public class DeathTsunami : MonoBehaviour
{

    public PostProcessingProfile fx;

    private PostProcessingBehaviour camImageFx;

    public GameObject GameOver;

    void Start()
    {

        camImageFx = FindObjectOfType<PostProcessingBehaviour>();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            camImageFx.profile = fx;

            GameOver.SetActive(true);
            Debug.Log("Play Game Over Screen");

            FindObjectOfType<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);

            FindObjectOfType<GameManager>().EndGame();
           
        }
    }
}