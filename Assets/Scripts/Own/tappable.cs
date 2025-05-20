using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tappable : MonoBehaviour
{
    public float cooldownTime = 5f; 
    private float lastMoveTime = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if (Time.time >= lastMoveTime + cooldownTime) 
            {
                MovePlayerToPosition();
                lastMoveTime = Time.time;
            }
        }
    }

    void MovePlayerToPosition()
    {
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0f; 
        transform.position = targetPosition;
    }
}
