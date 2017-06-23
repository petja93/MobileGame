using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager{

	public PoolManager(int poolSize, GameObject toPool){
		objects = new GameObject[poolSize];
		for (int i = 0; i < objects.Length; i++) {
			objects [i] = GameObject.Instantiate (toPool);
			objects [i].SetActive (false);
		}
	}

	private GameObject[] objects;
	private int nextReturnIndex = 0;
	private int nextInsertIndex = 0;

	public GameObject getObject(){
		GameObject returnValue = objects [nextReturnIndex];

		objects [nextReturnIndex] = null;
		nextReturnIndex++;
		nextReturnIndex %= objects.Length;
		returnValue.SetActive (true);
		return returnValue;
	}

	public void releaseObject(GameObject obj){
		objects [nextInsertIndex] = obj;
		nextInsertIndex++;
		nextInsertIndex %= objects.Length;
		obj.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
