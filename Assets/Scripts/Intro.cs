using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{

    private MovieTexture mt;
    private RectTransform rt;
    private AudioSource ac;
    private Vector2 origPos;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        ac = GetComponent<AudioSource>();
        origPos = rt.anchoredPosition;
        RawImage rim = GetComponent<RawImage>();
        mt = (MovieTexture)rim.mainTexture;
        mt.Play();
        ac.Play();

    }

    void Update()
    {
        if (Time.time > mt.duration || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(1);
        }
    }
}
