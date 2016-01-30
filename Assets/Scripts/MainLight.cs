using UnityEngine;
using System.Collections;

public class MainLight : MonoBehaviour
{

    public float speed = 6;
    private static bool turnOn, turnOff;
    private Light light;
    // Use this for initialization
    void Start()
    {
        light = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (turnOff)
        {
            light.intensity -= Time.deltaTime * speed;
        }
        else if (turnOn)
        {
            light.intensity += Time.deltaTime * speed;
        }
        CheckIntensity();
    }

    private void CheckIntensity()
    {
        if (light.intensity >= 1)
        {
            turnOn = false;
        }
        else if (light.intensity <= 0)
        {
            turnOff = false;
        }
    }

    public static void TurnOff()
    {
        turnOff = true;
    }

    public static void TurnOn()
    {
        turnOn = true;
    }
}
