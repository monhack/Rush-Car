﻿using System.Collections;
using UnityEngine;

public class manageUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // fungsi untuk pause
    public void Pause(){
        if (Time.timeScale == 1){
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0){
            Time.timeScale = 1;
        }
    }
}