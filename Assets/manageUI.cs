﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class manageUI : MonoBehaviour {

    public Text scoreText;
    bool gameOver;
    int score;

	// Use this for initialization
	void Start () {

        gameOver = false;
        score = 0; 
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
	}

	// Update is called once per frame
	void Update () {
         scoreText.text = "Score : " + score;
	}

    public void gameOverActivated(){
        gameOver = true;
    }

    void scoreUpdate(){
        if(gameOver == false){
            score += 1;
        }
        
    }

    public void Play() {
        Application.LoadLevel ("level1");
	}

    // fungsi untuk pause
    public void Pause(){
        if (Time.timeScale == 1){
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0){
            Time.timeScale = 1;
        }
        Application.LoadLevel("pauseScene");
    }

    public void Replay(){
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Restart(){
        Application.LoadLevel("level1");
    }

    public void Menu(){
        Application.LoadLevel("menuScene");
    }

    public void Exit(){
        Application.Quit ();
    }
}
