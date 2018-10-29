using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float distanceToMove;
    public float moveSpeed;
    private bool move;
    private Vector3 endPosition;
    
    
    void Start () {
        endPosition = transform.position;
    }
  
    void FixedUpdate () {
        if (move)
        {
            transform.position = Vector2.MoveTowards(transform.position, endPosition, moveSpeed * Time.deltaTime);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //Left
        {
            endPosition = new Vector3(endPosition.x - distanceToMove, endPosition.y);
            move = true;
        }
        if (Input.GetKeyDown(KeyCode.D)) //Right
        {
            endPosition = new Vector3(endPosition.x + distanceToMove, endPosition.y);
            move = true;
        }
        if (Input.GetKeyDown(KeyCode.W)) //Up
        {
            endPosition = new Vector3(endPosition.x, endPosition.y + distanceToMove);
            move = true;
        }
        if (Input.GetKeyDown(KeyCode.S)) //Down
        {
            endPosition = new Vector3(endPosition.x, endPosition.y - distanceToMove);
            move = true;
        }
    }
}