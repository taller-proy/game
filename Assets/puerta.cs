using UnityEngine;
using System.Collections;

public class puerta : MonoBehaviour {
	public int a=1, b=2;

	// Use this for initialization
	void Start () {
		Debug.Log("dfa");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

			Debug.Log(a+b);

	
	}
}
