﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public float speed = 10f;
   private Transform target;
   private int wavepointIndex = 0;
   
   void Start() {
	   target = WayPoints.points[0];
   }
   void Update() {
	   Vector3 dir = target.position - transform.position;
	   transform.Translate(dir.normalized * speed * Time.deltaTime);
   
   }
   
	   
}
