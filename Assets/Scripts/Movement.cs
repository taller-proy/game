﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        Debug.Log("Chy");
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
