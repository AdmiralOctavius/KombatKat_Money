﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldUsesCounter : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = "Shield Uses: " + player.GetComponent<PlayerMovement>().ShieldUses.ToString();

    }
}
