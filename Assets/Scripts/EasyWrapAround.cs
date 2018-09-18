using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyWrapAround : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform t = gameObject.transform;
        if (t.position.x <= -9)
            t.position =
                new Vector3(8.9f, t.position.y, t.position.z);
        else if (t.position.x >= 9)
            t.position =
                new Vector3(-8.9f, t.position.y, t.position.z);

        if (t.position.y <= -5)
            t.position =
                new Vector3(t.position.x, 4.9f, t.position.z);
        else if (t.position.y >= 5)
            t.position =
                new Vector3(t.position.x, -4.9f, t.position.z);
    }
}