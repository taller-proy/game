using UnityEngine;
using System.Collections;

public class RaycastPosition : MonoBehaviour
{

	int floorMaskObj;
	int floorMaskPos;
    float distance;
    GameObject objetoSeleccionado;
	Vector3 hitPoint;
	public bool objetoYaSeleccionado;

    void Awake()
    {
        floorMaskObj = LayerMask.GetMask("3DObject");
		floorMaskPos = LayerMask.GetMask("Mesa");
        distance = 100f;
        hitPoint = Vector3.up;
    }
   

    void Update()
    {
        RaycastHit hit;
		RaycastHit hitObj;
            
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(camRay.origin, camRay.direction * 100, Color.green);
		if (Physics.Raycast(camRay, out hit, distance, floorMaskPos))
            {

                // Create a vector from the player to the point on the floor the raycast from the mouse hit.
                hitPoint = hit.point;
			Debug.Log (hitPoint);
            }
        
		if (Physics.Raycast (camRay, out hitObj, distance, floorMaskObj) && !objetoYaSeleccionado) {

			// Create a vector from the player to the point on the floor the raycast from the mouse hit.
			objetoSeleccionado = hitObj.transform.gameObject;
			Debug.Log (objetoSeleccionado.name);
		} else if(!objetoYaSeleccionado){
			objetoSeleccionado = null;
		}


    }

    // Update is called once per frame
    public GameObject ObjetoSeleccionado()
    {
		return objetoSeleccionado;
    }

	public Vector3 PosicionAMover(){
		return hitPoint;
	}
}