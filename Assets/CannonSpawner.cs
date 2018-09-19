using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonSpawner : MonoBehaviour {

    public GameObject cannonBase;

	// Use this for initialization
	void Start () {
        Instantiate(cannonBase, new Vector3(0, 0, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
