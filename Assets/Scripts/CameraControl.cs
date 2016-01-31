using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class CameraControl : MonoBehaviour
{
    public float speed = 2, timer;
    public float maxLeft, maxRight, maxHeight, MaxBot;
    public float maxLeftNight, maxRightNight, maxHeightNight, MaxBotNight;
    public static bool night = false;
    private static bool stop = false;
    private GameObject cursor;
    private static Camera camera;
    private Sprite current, spr;


    // Use this for initialization
    void Start()
    {
        camera = this.GetComponent<Camera>();
        camera.backgroundColor = Color.black;
        cursor = GameObject.FindGameObjectWithTag("Cursor");
        spr = Resources.Load<Sprite>("cursor2");
        current = cursor.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        MoveMouse();
        if (!stop)
        {
            CheckPosition();
        }
        if (Input.GetMouseButton(0))
        {
            cursor.GetComponent<SpriteRenderer>().sprite = spr;
            timer = 0;
        }
        if (timer >= 0.2)
        {
            cursor.GetComponent<SpriteRenderer>().sprite = current;
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
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = camera.nearClipPlane;
        Vector3 position = camera.ScreenToWorldPoint(mousePosition);
        cursor.transform.position = position;
    }

    private void CheckPosition()
    {
        Vector3 screenPos = camera.WorldToScreenPoint(cursor.transform.position);
        Debug.Log(screenPos);
        if (screenPos.x < 0.1)
        {
            MoveLeft();
        }
        else if ((camera.pixelWidth - screenPos.x) < 1 || screenPos.x >= camera.pixelWidth - 3)
        {
            MoveRight();
        }
        else if (screenPos.y < 0.1)
        {
            MoveDown();
        }
        else if ((camera.pixelHeight - screenPos.y) < 1 || screenPos.y >= camera.pixelHeight - 3)
        {
            MoveUp();
        }
    }

    private void MoveLeft()
    {
        if (this.gameObject.transform.position.x >= maxLeft && !night)
        {
            this.gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.left * speed * Time.deltaTime;
            Debug.Log("left");
        }
        else if (this.gameObject.transform.position.x >= maxLeftNight && night)
        {
            this.gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.left * speed * Time.deltaTime;
            Debug.Log("left");
        }
    }

    private void MoveRight()
    {
        if (this.gameObject.transform.position.x < maxRight && !night)
        {
            this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.right * speed * Time.deltaTime;
            Debug.Log("right");
        }
        else if (this.gameObject.transform.position.x < maxRightNight && night)
        {
            this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.right * speed * Time.deltaTime;
            Debug.Log("right");
        }
    }

    private void MoveUp()
    {
        if (this.gameObject.transform.position.y < maxHeight && !night)
        {
            this.gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.up * speed * Time.deltaTime;
            Debug.Log("top");
        }
        else if (this.gameObject.transform.position.y < maxHeightNight && night)
        {
            this.gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.up * speed * Time.deltaTime;
            Debug.Log("top");
        }
    }

    private void MoveDown()
    {
        if (this.gameObject.transform.position.y > MaxBot && !night)
        {
            this.gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.down * speed * Time.deltaTime;
            Debug.Log("bot");
        }
        else
        if (this.gameObject.transform.position.y > MaxBotNight && night)
        {
            this.gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
            this.cursor.transform.position += Vector3.down * speed * Time.deltaTime;
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

    public void ChangeTime()
    {
        if (night && !stop)
        {
            night = false;
            camera.gameObject.transform.position = new Vector3(-30.1f, 2.29f, -10);
        }
        else if (!night && !stop)
        {
            night = true;
            camera.gameObject.transform.position = new Vector3(97, 2.29f, -10);
        }
    }

}
