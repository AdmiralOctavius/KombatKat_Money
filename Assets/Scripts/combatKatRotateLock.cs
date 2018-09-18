using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatKatRotateLock : MonoBehaviour {

    //Accquired this code from: 
    Quaternion rotation;
    void Awake()
    {
        rotation = transform.rotation;
    }
    void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
