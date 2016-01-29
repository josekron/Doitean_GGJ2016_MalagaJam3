using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public float min = 0.0f;
    public float max = 1f;
    public float duration = 5.0f;

    private float startTime;
    private SpriteRenderer sprite;

    void Start()
    {
        //Get sprite renderer
        sprite = this.GetComponent<SpriteRenderer>();
        //Get the time
        startTime = Time.time;
    }

    void Update()
    {

    }

    //Fade out/in the sprite
    public void fade()
    {
        float t = (Time.time - startTime) / duration;
        sprite.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(min, max, t));
    }
}
