using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadlevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

   public void OnTriggerEnter()
    {

        Application.LoadLevel(1);

    }
	
	
}
