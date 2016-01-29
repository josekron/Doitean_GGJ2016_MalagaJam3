using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float speed = 2;
    public float maxLeft, maxRight, maxHeight;

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
        else if ((Screen.height - position.y) < 5 && this.gameObject.transform.position.y < maxHeight)
        {
            this.gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
            Debug.Log("top");
        }
        else if (position.y < 5 && this.gameObject.transform.position.y > 0)
        {
            this.gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
            Debug.Log("bot");
        }
    }
}
