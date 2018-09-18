using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour {

    public GameObject objToSpawn;
    public GameObject projectile;
    // Use this for initialization

    public bool isOn;
    public float fireRate = 2;
    private float lastFireTime = float.MinValue;

    private Vector2 target1;
    private Vector2 target2;
    public bool send;
    public float speed;
    void Start () {
        isOn = true;
        target1 = new Vector2(3, 3);
        target2 = new Vector2(-3, -3);
        send = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isOn)
        {
            if (Time.time - (1 / fireRate) > lastFireTime)
            {
                GameObject clone;
                clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector2.left * 10);
                //GameObject bullet = Instantiate(objToSpawn, gameObject.transform.position, Quaternion.identity);
                //bullet
                lastFireTime = Time.time;
            }

            if (send)
            {
                transform.Translate(target2 * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(target1 * speed * Time.deltaTime);    
            }
        }
	}


}
