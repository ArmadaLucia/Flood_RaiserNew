using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsunamiTrigger : MonoBehaviour
{

    public GameObject Tsunami;
    public ConstantMovement Water;

    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            Debug.Log("Tsunami Triggered!");
            Tsunami.SetActive(true);
        }
    }
}