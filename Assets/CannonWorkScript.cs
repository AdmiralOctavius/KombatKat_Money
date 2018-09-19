using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonWorkScript : MonoBehaviour {

        public Vector3 pointB;
        private Vector3 pointA;
        void Start()
        {

            pointA = transform.position;
           
        }
        void Update()
    {
        while (true)
        {
            MoveObject(transform, pointA, pointB, 3.0f);
            MoveObject(transform, pointB, pointA, 3.0f);
        }
    }
        void MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
        {
            float i = 0.0f;
            float rate = 1.0f / Time.time;
            while (i < 1.0f) {
                i += Time.deltaTime * rate;
                thisTransform.position = Vector3.Lerp(startPos, endPos, i);
                
            }
        }
}
