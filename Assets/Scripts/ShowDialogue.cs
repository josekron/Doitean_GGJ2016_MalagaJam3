using UnityEngine;
using System.Collections;

public class ShowDialogue : MonoBehaviour
{

    public GameObject dialogue;

    private AudioSource[] audioSources;
    private bool isSounded;

    // Use this for initialization
    void Start()
    {
        GameObject father = transform.root.gameObject;
        audioSources = father.GetComponents<AudioSource>();
        isSounded = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (!isSounded) {
            this.audioSources[0].Play();
            isSounded = true;
        }
        
        dialogue.SetActive(true);

    }

    void OnMouseEnter()
    {
        CursorController.DoAnimation();
    }

    void OnMouseExit()
    {
        CursorController.StopAnimation();
    }
}
