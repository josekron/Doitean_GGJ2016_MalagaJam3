using UnityEngine;
using System.Collections;

public class NPCController : MonoBehaviour
{

    private SavedNPC saved;

    // Use this for initialization
    void Start()
    {
        saved = GameObject.Find("Main Camera").GetComponent<SavedNPC>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            saved.SaveNPC(this.gameObject);
        }
    }
}
