using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour {

    public GameObject objToSpawn;
    public GameObject projectile;
    // Use this for initialization

    public bool isOn;
    public float fireRate = 2;

    public Vector3 target1;
    public Vector3 target2;
    public bool send;
    public float speed;
    public float rotateSpeed;

    //Need this for rotation
    private Transform target1Rot;
    private Quaternion testRotation;
    private Vector3 startPos;
    private Vector3 distance;
    private Vector3 currPos;
    private float lastFireTime = float.MinValue;

    //Testing out code
    //private float startTime;
    //private float journeyLength;
    //private float distCovered;
    //private float fracJourney;
    //private float moveSpeed;
    //[SerializeField] private GameObject pointA;
    //[SerializeField] private GameObject pointB;
    //[SerializeField] private Transform objectToUse;
    //[SerializeField] private bool reverseMove = false;

    void Start() {
        isOn = true;
        //target1 = new Vector2(3, 3);
        //target2 = new Vector2(-3, -3);
        send = true;
        startPos = gameObject.GetComponent<Transform>().position;

        //Testing Code
        //startTime = Time.time;
        //journeyLength = Vector2.Distance(pointA.transform.position, pointB.transform.position);
        //objectToUse = transform;

        target1.x = 5;
        target1.y = 5;
        target1.z = 0;

        //testRotation.SetEulerAngles(0, 0, 30);
        testRotation = Quaternion.Euler(0, 0, 30);
        //Vector3 rot = new Vector3(0, 0, 30);
        //float angle = 0.0f;
        //testRotation.ToAngleAxis(out angle, out rot);
    }
    //target1Rot = new Transform();
    //target1Rot.eulerAngles = new Vector3(0, 0, 30);
    

        
	
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
            //http://theflyingkeyboard.net/unity/unity-c-moving-gameobject-from-point-a-to-point-b/
            /*distCovered = (Time.time - startTime) * moveSpeed;
            fracJourney = distCovered / journeyLength;

            if (reverseMove)
            {
                objectToUse.position = Vector2.Lerp(pointB.transform.position, pointA.transform.position, fracJourney);
            }
           else
            {
                objectToUse.position = Vector2.Lerp(pointA.transform.position, pointB.transform.position, fracJourney);
            }
            
            if ((Vector2.Distance(objectToUse.position, pointB.transform.position) == 0.0f || Vector2.Distance(objectToUse.position, pointA.transform.position) == 0.0f)) //Checks if the object has travelled to one of the points
            {
                if (reverseMove)
                {
                    reverseMove = false;
                }
                else
                {
                    reverseMove = true;
                }
                startTime = Time.time;
            }
            */
            if (send)
             {
                float angle = Mathf.Sin(Time.time) * 1; //tweak this to change frequency

                //transform.localRotation = Quaternion.AngleAxis(angle, Vector3.forward);
                //transform.rotation = Quaternion.FromToRotation(Vector3.forward, transform.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, testRotation , rotateSpeed);
                
                distance = startPos - target1;
                //transform.Translate(target1 * speed * Time.deltaTime);
                    transform.position = Vector2.MoveTowards(transform.position, target1, speed);
                 currPos = gameObject.GetComponent<Transform>().position;
                 if (currPos == target1)
                 {
                     send = false;
                 }
             }
             else
             {
                 distance = startPos - target1;
                 //transform.Translate(target2 * speed * Time.deltaTime);
                 transform.position = Vector2.MoveTowards(transform.position, startPos, speed);
                 currPos = gameObject.GetComponent<Transform>().position;
                 if (currPos == startPos)
                 {
                     send = true;
                 }
             }
        }
	}


}
