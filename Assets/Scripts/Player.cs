﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : GameController {

	public static GameObject player;

    private GameMaster gm;

    

	// pelaajan nopeus
	public float playerSpeed = 0.03f;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();

	}

	// Update is called once per frame
	void Update () {
		Movement (playerSpeed);
	}

	// player movements
	public void Movement (float playerSpeed){

		if (Input.GetKey("up")) {
			//Debug.Log ("Move up");
			player.transform.Translate (0, playerSpeed, 0);
		}
		else if (Input.GetKey("up") && Input.GetKey("left")) {
			//Debug.Log ("Move up/left");
			player.transform.Translate (-playerSpeed, playerSpeed, 0);
		}
		else if (Input.GetKey("down")) {
			//Debug.Log ("Move down");
			player.transform.Translate (0, -playerSpeed, 0);
		}
		else if (Input.GetKey("left")) {
			//Debug.Log ("Move left");
			player.transform.Translate (-playerSpeed, 0, 0);
		}
		else if (Input.GetKey("right")) {
			//Debug.Log ("Move right");
			player.transform.Translate (playerSpeed, 0, 0);
		}
	}

	// kolikkosettii
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
            gm.points += 1;
        }
    }

}
