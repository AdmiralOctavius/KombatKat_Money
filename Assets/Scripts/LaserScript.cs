using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

	void Start()
    {
        Invoke("DieOff", 3);
        gameObject.GetComponent<Rigidbody2D>().velocity = (10 * gameObject.transform.right);
    }

    void Update()
    {

    }

    void DieOff()
    {
        Destroy(gameObject);
    }
}
