using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //gameObject.transform.position = player.position + new Vector3(0,0,-10);
        Vector3 newPosition = player.position;
        newPosition.z = gameObject.transform.position.z;

	}
}
