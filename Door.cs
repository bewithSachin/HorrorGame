using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public bool open = false;
    public float doorOpenAngle = 90f;
    public float doorClosedAngle = 0f;
    public float smooth = 2f; // speed of rotation;


	public void ChangeDoorState()
    {

        open = !open;


    }
	
	// Update is called once per frame
	void Update () {
        if (open) //open == true
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorClosedAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }
}