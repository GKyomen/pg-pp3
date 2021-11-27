using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {
	public GameObject cam1;
	public GameObject cam2;
	public GameObject cam3;


    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("1Key")) {
			cam1.SetActive(true);
			cam2.SetActive(false);
			cam3.SetActive(false);
		}

		if(Input.GetButtonDown("2Key")) {
			cam2.SetActive(true);
			cam1.SetActive(false);
			cam3.SetActive(false);
		}

		if(Input.GetButtonDown("3Key")) {
			cam3.SetActive(true);
			cam1.SetActive(false);
			cam2.SetActive(false);
		}
    }
}
