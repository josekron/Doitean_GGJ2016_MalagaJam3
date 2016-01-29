using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour
{
    public float max, min, time;
    private Renderer rend;
    // Use this for initialization
    void Start()
    {
        rend = this.GetComponent<SpriteRenderer>();
        fade();
    }

    void Update()
    {
        //fade();
    }

    void fade()
    {
        /*Color color = rend.material.color;
        color.a = new Color(1f, 1f, 1f, Mathf.SmoothStep(max, min, time));*/
        Color col = new Color(1f, 1f, 1f, Mathf.SmoothStep(max, min, time));
        rend.material.color = col;

    }
}
