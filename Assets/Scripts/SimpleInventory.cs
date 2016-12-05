﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This script is attached to the player gameobject and to the sinventoy panel.
/// Here we first create and find the item icon objects. Then we define what happens when the player's
///  collider reacts to the quest items' colliders. 
/// </summary>

public class SimpleInventory : MonoBehaviour {  

	public GameObject Antidote;
	public GameObject Key;
	public GameObject Map;				
	public GameObject CandyCane;
	public GameObject Book;


	void Start () {

		Antidote= GameObject.Find ("I_Antidote").GetComponent<GameObject> ();
		Key = GameObject.Find ("I_Key01").GetComponent<GameObject> ();  
		Map = GameObject.Find ("I_Map").GetComponent<GameObject> ();
		CandyCane = GameObject.Find ("W_Mace010").GetComponent<GameObject> ();
		Book = GameObject.Find ("I_Book").GetComponent<GameObject> (); 

	}

	void OnTriggerEnter2D(Collider2D col)
	{


		if (col.CompareTag("Key"))
		{
			Destroy(col.gameObject);
			Debug.Log ("found key");
			Key.SetActive (true);

		}
		if (col.CompareTag("Antidote"))
		{ 
			Destroy(col.gameObject);
			Debug.Log ("found antidote");
			Antidote.SetActive(true); 

		}
		if (col.CompareTag("Map"))
		{ 
			Destroy(col.gameObject);
			Debug.Log ("found map");
			Map.SetActive (true);
		}
		if (col.CompareTag("CandyCane"))
		{
			Destroy(col.gameObject);
			Debug.Log ("found candy cane");
			CandyCane.SetActive (true);

		}
		if (col.CompareTag("Book"))
		{ 
			Destroy(col.gameObject);
			Debug.Log ("found book");
			Book.SetActive (true);
		}

	}

	void Update () {
		
	}

}
