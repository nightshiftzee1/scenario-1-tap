using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayer : MonoBehaviour
{
private Rigidbody2D rb;
private Vector3 spawn;

void Awake(){
	rb = gameObject.GetComponent<Rigidbody2D>();}

void Start()
{
spawn = rb.position; 
}

void OnTriggerEnter2D(Collider2D other)
{
if (other.gameObject.CompareTag("Kill"))
{
rb.position = spawn;
}
}
}