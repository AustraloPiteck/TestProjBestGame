using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody2D))]
public sealed class Controller : MonoBehaviour
{
   [Header("Main")]
   [SerializeField] private float _speed;
   [SerializeField] private Rigidbody2D _rigidbody;
   
   private void Update()
   {
      Move();
   }

   private void Move()
   {
      float xAxis = Input.GetAxisRaw("Horizontal");
      _rigidbody.velocity = new Vector2(xAxis, transform.position.y).normalized  * _speed;
   }

  
}
