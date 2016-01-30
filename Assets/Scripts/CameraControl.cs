using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    public float speed = 2, backgroundBotSpeed, backgroundMiddleSpeed, backgroundTopSpeed;
    public float maxLeft, maxRight, maxHeight;
    private RawImage backgroundBot, backgroundMiddle, backgroundTop;


    // Use this for initialization
    void Start()
    {
        backgroundBot = GameObject.Find("CanvasBackground").GetComponentInChildren<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") == 0)
        {
            MoveMouse();
        }
        else
        {
            MovePad();
        }
    }

    void MovePad()
    {
        if (Input.GetAxis("Horizontal") == -1)
        {
            MoveLeft();
        }
        else if (Input.GetAxis("Horizontal") == 1)
        {
            MoveRight();
        }

        if (Input.GetAxis("Vertical") == 1)
        {
            MoveUp();
        }
        else if (Input.GetAxis("Vertical") == -1)
        {
            MoveDown();
        }
    }

    void MoveMouse()
    {
        Vector3 position = Input.mousePosition;
        if ((Screen.width - position.x) < 5)
        {
            MoveRight();
        }
        else if (position.x < 5)
        {
            MoveLeft();
        }
        else if ((Screen.height - position.y) < 5)
        {
            MoveUp();
        }
        else if (position.y < 5)
        {
            MoveDown();
        }
    }


    private void MoveLeft()
    {
        if (this.gameObject.transform.position.x >= maxLeft)
        {
            this.gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
            backgroundBot.uvRect = new Rect(backgroundBot.uvRect.x - backgroundBotSpeed, backgroundBot.uvRect.y, backgroundBot.uvRect.width, backgroundBot.uvRect.height);
            backgroundMiddle.uvRect = new Rect(backgroundMiddle.uvRect.x - backgroundMiddleSpeed, backgroundMiddle.uvRect.y, backgroundMiddle.uvRect.width, backgroundMiddle.uvRect.height);
            backgroundTop.uvRect = new Rect(backgroundTop.uvRect.x - backgroundTopSpeed, backgroundTop.uvRect.y, backgroundTop.uvRect.width, backgroundTop.uvRect.height);
            Debug.Log("left");
        }
    }

    private void MoveRight()
    {
        if (this.gameObject.transform.position.x < maxRight)
        {
            this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
            backgroundBot.uvRect = new Rect(backgroundBot.uvRect.x + backgroundBotSpeed, backgroundBot.uvRect.y, backgroundBot.uvRect.width, backgroundBot.uvRect.height);
            backgroundMiddle.uvRect = new Rect(backgroundMiddle.uvRect.x + backgroundMiddleSpeed, backgroundMiddle.uvRect.y, backgroundMiddle.uvRect.width, backgroundMiddle.uvRect.height);
            backgroundTop.uvRect = new Rect(backgroundTop.uvRect.x + backgroundTopSpeed, backgroundTop.uvRect.y, backgroundTop.uvRect.width, backgroundTop.uvRect.height);
            Debug.Log("right");
        }
    }

    private void MoveUp()
    {
        if (this.gameObject.transform.position.y < maxHeight)
        {
            this.gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
            Debug.Log("top");
        }
    }

    private void MoveDown()
    {
        if (this.gameObject.transform.position.y > 0)
        {
            this.gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
            Debug.Log("bot");
        }
    }
}
