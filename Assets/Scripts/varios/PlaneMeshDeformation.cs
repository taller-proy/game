﻿using UnityEngine;
using System.Collections;

public class PlaneMeshDeformation : MonoBehaviour {


	//PLANE

	public bool Editable;

	public GameObject point1;

	public GameObject point2;

	public GameObject point3;

	public GameObject point4;

	public Material MyTextureMaterial;

	void Start () 
	{
		if(!Editable)
		{

			//MODE 1 = classic generated mesh planes (easiest) Static

			Vector3[] Verticles = new Vector3[] 
			{
				new Vector3(0,0,0),new Vector3(1,0,0),new Vector3(0,1,0), new Vector3(1,1,0)
			};
			
			int[] Triangles = new int[] 
			{
				0,3,1,
				3,0,2 
			};

			/*
			int[] Triangles = new int[6] ;

			Triangles[0] = 0;
			Triangles[1] = 3;
			Triangles[2] = 1;

			Triangles[3] = 3;
			Triangles[4] = 0;
			Triangles[5] = 2;
			*/

			Vector2[] UV = new Vector2[] 
			{
				new Vector2(0,0),
				new Vector2(1,0),
				new Vector2(0,1),
				new Vector2(1,1),
			};
			
			Vector3[] Normals = new Vector3[]
			{
				Vector3.up,
				Vector3.up,
				Vector3.up,
				Vector3.up
			};
			
			if(!transform.GetComponent<MeshFilter>())
			{
				transform.gameObject.AddComponent<MeshFilter>();
			}
			if(!transform.GetComponent<MeshRenderer>())
			{
				transform.gameObject.AddComponent<MeshRenderer>();
			}
			
			Mesh myMesh = new Mesh();
			
			myMesh.vertices = Verticles;
			myMesh.triangles = Triangles;
			myMesh.normals = Normals;
			myMesh.uv = UV;
			;

			transform.GetComponent<MeshFilter>().mesh = myMesh;

			transform.GetComponent<Renderer>().material = MyTextureMaterial;
		}
	}




















	void Update () 
	{
	

		//MODE 2 = Editable Plane

		if(Editable)
		{
	        Vector3[] Verticles = new Vector3[] 
			{
				//One side, one face (plane)
				point1.transform.position,point2.transform.position,point3.transform.position,point4.transform.position
			};

			int[] Triangles = new int[] 
			{
				0,3,1,
				3,0,2 
			};

			Vector2[] UV = new Vector2[] 
			{
				new Vector2(0,0),
				new Vector2(1,0),
				new Vector2(0,1),
				new Vector2(1,1),
			};

			Vector3[] Normals = new Vector3[]
			{
				Vector3.up,
				Vector3.up,
				Vector3.up,
				Vector3.up
			};

			if(!transform.GetComponent<MeshFilter>())
			{
				transform.gameObject.AddComponent<MeshFilter>();
			}
			if(!transform.GetComponent<MeshRenderer>())
			{
				transform.gameObject.AddComponent<MeshRenderer>();
			}

			Mesh myMesh = new Mesh();

			myMesh.vertices = Verticles;
			myMesh.triangles = Triangles;
			myMesh.normals = Normals;
			myMesh.uv = UV;
			;

			transform.GetComponent<MeshFilter>().mesh = myMesh;

			transform.GetComponent<Renderer>().material = MyTextureMaterial;

		}

	}
}


//FULL TUTORIAL YOU CAN FIND HERE: https://www.youtube.com/watch?v=c-pqEHR1jnw
//Tutorial by matt... Thanks!












