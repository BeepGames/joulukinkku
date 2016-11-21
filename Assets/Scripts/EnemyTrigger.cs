﻿using UnityEngine;
using System.Collections;

public class EnemyTrigger : Enemy {

	public static GameObject EnemyCollider;

	private static bool touching = false;

	public static Transform lookAtPlayer;

	// enemy
	private static GameObject enemy;

	public static Vector2 paska;

	private static float enemyX;

	private static float enemyY;


	//player
	public static GameObject pelaaja;

	private static Vector2 pelaajaVector;

	private static float pelaajaX;

	private static float pelaajaY;

	// vihollisen nopeus
	public static float enemySpeed = 0.02f;

	// vihun vector2
	// private static Vector2 enemyVector = enemy.transform.position;

	// mitä kohti lähdetään EnemyAggro () : ssa
	// public static Vector2 playerMan = Player.player.transform.position;

	// private static Transform transform;


	// Use this for initialization
	void Start () {
		enemy = GameObject.Find ("Enemy");
		//Vector2 paska = enemy.transform.position;

		pelaaja = GameObject.Find ("Player");
		//Vector2 pelaajaVector = pelaaja.transform.position;

		EnemyCollider = GameObject.Find ("EnemyTrigger");

	}
	
	// Update is called once per frame
	void Update () {
		//pelaajan x ja y
		pelaajaX = pelaaja.transform.position.x;
		pelaajaY = pelaaja.transform.position.y;

		// vihollisen x j y
		enemyX = enemy.transform.position.x;
		enemyY = enemy.transform.position.y;

		// Debug.Log (paska);
		//Debug.Log(pelaaja.transform.position.x);
		Vector2 paska = enemy.transform.position;
		Vector2 pelaajaVector = pelaaja.transform.position;
	}
		
	// enemysettii
	public static void EnemyWalk (){
		//transform.LookAt (lookAtPlayer);
		pahiskeho.velocity = new Vector2 (pelaajaX , pelaajaY);
	}

	public static void EnemyAggro (){

		if (touching){
			// Debug.Log ("enemy triggered");
			EnemyWalk ();
		}
	}

	// kun pelaaja osuu vihollisen enemytrigger- alueelle
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			touching = true;
		}
	}

	// hieman turha, yläolevan vastakohta
	void OnTriggerExit2D(Collider2D other) {
		if (other.tag != "Player") {
			touching = false;
		}
	}
}
