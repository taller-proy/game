using UnityEngine;
using System.Collections;

public class MoverElemento : MonoBehaviour {
	public GameObject cameraWithRaycast;
	RaycastPosition rayPos;
	GameObject objectoAMover;
	bool activarMovimiento;
	void Awake() {
		rayPos = cameraWithRaycast.GetComponent<RaycastPosition>();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        /*print("lel");
		if (Input.GetMouseButtonDown (0)) {
			
			if (rayPos.ObjetoSeleccionado()!= null) {
				objectoAMover =  Instantiate(rayPos.ObjetoSeleccionado(), rayPos.ObjetoSeleccionado().transform.position, Quaternion.identity) as GameObject;
				if (!activarMovimiento) {
					activarMovimiento = true;
					rayPos.objetoYaSeleccionado = true;
				} else {
					rayPos.objetoYaSeleccionado = false;
					activarMovimiento = false;
				}

			}
		}

		if (activarMovimiento) {
			objectoAMover.transform.position = CalcularPosicion();
		}*/

    }

	Vector3 CalcularPosicion() {
		return new Vector3(rayPos.PosicionAMover().x, objectoAMover.transform.position.y ,rayPos.PosicionAMover().z);
	}
}
