using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAroundPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.x <= -8)
        {
            gameObject.transform.position = new Vector3(7.99f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if(gameObject.transform.position.x >= 8)
        {
            gameObject.transform.position = new Vector3(-7.99f, gameObject.transform.position.y, gameObject.transform.position.y);
        }

        if (gameObject.transform.position.y <= -4.5)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 4.499f, gameObject.transform.position.z);
        }
        else if (gameObject.transform.position.y >= 4.5)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -4.499f, gameObject.transform.position.y);
        }
    }
}
