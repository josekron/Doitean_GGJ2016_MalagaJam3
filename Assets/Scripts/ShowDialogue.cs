using UnityEngine;
using System.Collections;

public class ShowDialogue : MonoBehaviour {

    public GameObject dialogue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("acitvate dialogue: " + dialogue.name);
        //GameObject dialogue = this.transform.Find("DialoguePrefab").gameObject;
        dialogue.SetActive(true);

    }
}
