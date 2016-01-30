using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    public float speed = 2, backgroundBotSpeed, backgroundMiddleSpeed, backgroundTopSpeed;
    public float maxLeft, maxRight, maxHeight, MaxBot;
    private static bool stop = false;
    private RawImage backgroundBot, backgroundMiddle, backgroundTop;
    private GameObject cursor;
    private static Camera camera;


    // Use this for initialization
    void Start()
    {
        //backgroundBot = GameObject.Find("CanvasBackground").GetComponentInChildren<RawImage>();
        camera = this.GetComponent<Camera>();
        cursor = GameObject.FindGameObjectWithTag("Cursor");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            MoveMouse();
        }
        else
        {
            MovePad();
        }
        if (!stop)
        {
            CheckPosition();
        }
    }

    void MovePad()
    {
        float x, y;
        x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        cursor.transform.Translate(x, y, 0);
    }

    void MoveMouse()
    {
        Vector3 position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z += 10;
        cursor.transform.position = position;
    }

    private void CheckPosition()
    {
        Vector3 screenPos = camera.WorldToScreenPoint(cursor.transform.position);

        if (screenPos.x < 1)
        {
            MoveLeft();
        }
        else if ((camera.pixelWidth - screenPos.x) < 1 || screenPos.x == camera.pixelWidth - 1)
        {
            MoveRight();
        }
        else if (screenPos.y < 1)
        {
            MoveDown();
        }
        else if ((camera.pixelHeight - screenPos.y) < 1 || screenPos.y == camera.pixelHeight - 1)
        {
            MoveUp();
        }
    }

    private void MoveLeft()
    {
        if (this.gameObject.transform.position.x >= maxLeft)
        {
            this.gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
            /* backgroundBot.uvRect = new Rect(backgroundBot.uvRect.x - backgroundBotSpeed, backgroundBot.uvRect.y, backgroundBot.uvRect.width, backgroundBot.uvRect.height);
             backgroundMiddle.uvRect = new Rect(backgroundMiddle.uvRect.x - backgroundMiddleSpeed, backgroundMiddle.uvRect.y, backgroundMiddle.uvRect.width, backgroundMiddle.uvRect.height);
             backgroundTop.uvRect = new Rect(backgroundTop.uvRect.x - backgroundTopSpeed, backgroundTop.uvRect.y, backgroundTop.uvRect.width, backgroundTop.uvRect.height);
            */
            Debug.Log("left");
        }
    }

    private void MoveRight()
    {
        if (this.gameObject.transform.position.x < maxRight)
        {
            this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
            /*  backgroundBot.uvRect = new Rect(backgroundBot.uvRect.x + backgroundBotSpeed, backgroundBot.uvRect.y, backgroundBot.uvRect.width, backgroundBot.uvRect.height);
              backgroundMiddle.uvRect = new Rect(backgroundMiddle.uvRect.x + backgroundMiddleSpeed, backgroundMiddle.uvRect.y, backgroundMiddle.uvRect.width, backgroundMiddle.uvRect.height);
              backgroundTop.uvRect = new Rect(backgroundTop.uvRect.x + backgroundTopSpeed, backgroundTop.uvRect.y, backgroundTop.uvRect.width, backgroundTop.uvRect.height);
             */
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
        if (this.gameObject.transform.position.y > MaxBot)
        {
            this.gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
            Debug.Log("bot");
        }
    }

    public static void LookAtCharacter(GameObject character)
    {
        stop = true;
        camera.transform.LookAt(character.transform);
        camera.orthographicSize = 1;
    }

    public static void StopLook()
    {
        camera.orthographicSize = 5;
        stop = false;
    }

    public static void StartStop(bool state)
    {
        stop = state;
    }

}
