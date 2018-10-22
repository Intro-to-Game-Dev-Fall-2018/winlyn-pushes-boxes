using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed;
	
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void FixedUpdate () 
    {
        float moveVertical = Input.GetAxis("Vertical");
        transform.Translate(0, moveVertical * speed * Time.deltaTime, 0);

        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(moveHorizontal * speed * Time.deltaTime, 0, 0);
    }
}