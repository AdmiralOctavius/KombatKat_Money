using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAround : MonoBehaviour {

    public GameObject endPoint;
    public bool isVerticalWall = true;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (endPoint != null)
        {
            Transform t = col.gameObject.transform;
            if (isVerticalWall)
                t.position = new Vector3(endPoint.transform.position.x, t.position.y, t.position.z);
            else
                t.position = new Vector3(t.position.x, endPoint.transform.position.y, t.position.x);
        }
    }
}
