using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float speed = 2;
    public float maxLeft, maxRight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 position = Input.mousePosition;
        if ((Screen.width - position.x) < 5 && this.gameObject.transform.position.x < maxRight)
        {
            this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
            Debug.Log("right");
        }
        else if (position.x < 5 && this.gameObject.transform.position.x >= maxLeft)
        {
            this.gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
            Debug.Log("left");
        }
    }
}
