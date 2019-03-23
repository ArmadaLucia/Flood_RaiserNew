using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;

public class Death : MonoBehaviour{

    public PostProcessingProfile fx;
    public Rigidbody rb;

    public GameObject GameOver;
    public GameObject Tsunami;

    private PostProcessingBehaviour camImageFx;

    void Start()
    {

        camImageFx = FindObjectOfType<PostProcessingBehaviour>();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Play UI screen");
            //red screen
            camImageFx.profile = fx;
            //player stops moving
            rb.isKinematic = true;

            GameOver.SetActive(true);
            Debug.Log("Play Game Over Screen");

            FindObjectOfType<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);

            Tsunami.SetActive(false);

            /*
            Cursor.visible = true; //Werkt nog niet
            Cursor.lockState = CursorLockMode.None; //Werkt nog niet
            */

            FindObjectOfType<GameManager>().EndGame();


        }
    }
}
