using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class End : MonoBehaviour
{
	private bool end;

	private bool end1;

	private bool end2;

	// Use this for initialization
	void Start()
	{

	}

	void Update()
	{

	}

	void OnTriggerStay2D(Collider2D otherObj)
	{
		if (otherObj.gameObject.CompareTag("crate"))
		{
			end = true;
		}
		if (otherObj.gameObject.CompareTag("crate1"))
		{
			end1 = true;
		}
		if (otherObj.gameObject.CompareTag("crate2"))
		{
			end2 = true;
		}
	}

	void FixedUpdate()
	{

		if (end == true && end1 == true && end2 == true)
		{
			Debug.Log("You Win!");
			SceneManager.LoadScene("SampleScene");
		}
	}
}