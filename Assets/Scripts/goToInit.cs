using UnityEngine;
using System.Collections;

public class goToInit : MonoBehaviour {

    private AudioSource[] audioSources;

    private float TICK_LEVEL_INITIAL = 0.5f;
    private float timeLevel = 0;
    private bool ok;

    // Use this for initialization
    void Start()
    {
        audioSources = GetComponents<AudioSource>();
        ok = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ok)
        {
            timeLevel += Time.deltaTime;
            if (timeLevel > TICK_LEVEL_INITIAL)
            {
                timeLevel -= TICK_LEVEL_INITIAL;
                Application.LoadLevel("Game");
            }
        }
    }

    void OnMouseDown()
    {
        Debug.Log("empezar de nuevo");
        if (!ok)
        {
            audioSources[0].playOnAwake = true;
            this.audioSources[0].Play();
            ok = true;
        }

    }
}
