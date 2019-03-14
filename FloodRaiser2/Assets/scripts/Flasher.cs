using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flasher : MonoBehaviour {


    public GameObject selection;
    public int redCol;
    public int greenCol;
    public int blueCol;
    public bool LookingAtObject = false;
    public bool flashingIn = true;
    public bool startedFlashing = false;

    private void Update()
    {
        if (LookingAtObject == true)
        {
            selection.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);
        }
    }

    void OnMouseOver()
    {
        LookingAtObject = true;
        if(startedFlashing == false)
        {
            startedFlashing = true;
        }
    }

    void OnMouseExit()
    {
        startedFlashing = false;
        LookingAtObject = false;
        selection.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
    }

}
