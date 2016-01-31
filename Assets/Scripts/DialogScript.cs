using UnityEngine;
using System.Collections;

public class DialogScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        //GameObject father = transform.root.gameObject;
        //GameObject dialogue = father.transform.Find("DialoguePrefab").gameObject;
        //dialogue.SetActive(false);

        GameObject ob = transform.parent.parent.parent.parent.gameObject;
        ob.SetActive(false);
        //CameraControl.StartStop(false);
    }
}
