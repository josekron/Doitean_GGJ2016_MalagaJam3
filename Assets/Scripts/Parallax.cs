using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour
{
    //Mover x offset UV Rect
    public float speed = 2;
    private Vector2 offSet;
    private Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = this.GetComponent<Renderer>();
        offSet = rend.sharedMaterial.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * speed, 1);
        Vector2 offset = new Vector2(offSet.x, y);
        rend.sharedMaterial.mainTextureOffset = offSet;
    }


}
