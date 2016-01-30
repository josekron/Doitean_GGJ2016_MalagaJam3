using UnityEngine;
using System.Collections;

public class ChangeTime : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void ChangeToNight()
    {
        MainLight.TurnOff();
    }

    public static void ChangeToDay()
    {
        MainLight.TurnOn();
    }
}
