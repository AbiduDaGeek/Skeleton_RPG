using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
	private CheckPointManager cmp;
	void Start()
	{
		cmp = GameObject.FindGameObjectWithTag("CheckPointManager").GetComponent<CheckPointManager>();
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			cmp.lastCheckPointPos = transform.position;
		}
		
	}
}
