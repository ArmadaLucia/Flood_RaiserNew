using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastName : MonoBehaviour
{

    public GameObject selection;
    public int redCol;
    public int greenCol;
    public int blueCol;
    public bool LookingAtObject = false;
    public bool flashingIn = true;
    public bool startedFlashing = false;

    public static string selectedObject;
    public string internalObject;
    public RaycastHit theObject;

    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theObject))
        {
            selectedObject = theObject.transform.gameObject.name;
            internalObject = theObject.transform.gameObject.name;
        }

        if (LookingAtObject == true)
        {
            selection.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);
        }

    }
}
