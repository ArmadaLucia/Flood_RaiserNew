using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsunamiTrigger : MonoBehaviour
{

    public GameObject Tsunami;
    public ConstantForce Water;

    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            Debug.Log("Tsunami Triggered!");
            Tsunami.SetActive(true);

            Water.enabled = true;

            /*
            var myobj = FindObjectOfType<ConstantMovement>();
            myobj.enabled = true;
            */
        }
    }
}