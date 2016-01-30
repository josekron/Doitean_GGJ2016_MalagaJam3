using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour
{

    private static Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void DoAnimation()
    {
        anim.Play("Rotate");
    }

    public static void StopAnimation()
    {
        anim.Play("Default");
    }
}
