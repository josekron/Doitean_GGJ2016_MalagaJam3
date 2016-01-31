using UnityEngine;
using System.Collections;

public class goToExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void salir() {
        Application.LoadLevel("Game");
    }
}
