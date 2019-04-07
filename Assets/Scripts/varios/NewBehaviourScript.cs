using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

		public GameObject chica_Unity;
		public GameObject chica_2_3dsMax;
		public GameObject chico_1_Unity;
		public GameObject chico_2_Unity;
		public GameObject chico_3_Unity;
		public GameObject chica_3_Unity;

		// Use this for initialization
		void OnMouseDown () {
				if (Input.GetMouseButtonDown (0)) {
						if (chica_Unity.activeSelf) {
								chica_Unity.SetActive (false);
								chica_2_3dsMax.SetActive (false);
								chico_1_Unity.SetActive (true);
								chico_2_Unity.SetActive (false);
								chico_3_Unity.SetActive (false);
								chica_3_Unity.SetActive (false);

						}
				}

		}

	
	// Update is called once per frame
	void Update () {
	
	}
}
