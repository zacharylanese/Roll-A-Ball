using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
     Vector3 pointA = new Vector3(8f, 0.5f, 3f);
     Vector3 pointB = new Vector3(3f, 0.5f, 8f);
     void Update()
     {
         transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
     }
}
