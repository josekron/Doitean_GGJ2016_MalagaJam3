using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour
{
    private Light light;
    public float max;
    float random;
    // Use this for initialization
    void Start()
    {
        light = this.GetComponent<Light>();
        random = Random.Range(0.0f, 65535.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.time);
        light.intensity = Mathf.Lerp(2.0f, max, noise);
    }
}
