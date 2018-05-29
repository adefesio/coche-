using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorcohe : MonoBehaviour {

	public GameObject coche1;
	public GameObject coche2;
	public Text marcador1;
	public Text marcador2;
	int contador1;
	int contador2;
	bool final;

	void start(){
		contador1 = 0;
		contador2 = 0;
		final = false;
	}

	void Update () {
		if (!final) {
			if (contador1 == 100) {
				marcador1.text = "Has ganado";
				final = true;
			} else if (Input.GetKeyDown (KeyCode.F1)) {
				coche1.transform.Translate (0.1f, 0, 0); 
				contador1++;
				marcador1.text = "" + contador1;
			}		
			if (contador2 == 100) {
				marcador2.text = "Has ganado";
				final = true;
			} else if (Input.GetKeyDown (KeyCode.F3)) {
				coche2.transform.Translate (0.1f, 0, 0); 
				contador2++;
				marcador2.text = "" + contador2;
			}
		}
	}
}
