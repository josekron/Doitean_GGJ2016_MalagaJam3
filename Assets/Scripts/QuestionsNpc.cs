using UnityEngine;
using System.Collections;

public class QuestionsNpc : MonoBehaviour {

    public GameObject dialogue;


	
	// Update is called once per frame
	void Update () {
	
	}

    public void addResponse(int resp) {
        Debug.Log("Resp: "+resp);

        if (resp == 1 || resp == 6 || resp == 12)
        {
            if (resp != 12)
            {
                transform.parent.parent.parent.parent.gameObject.SetActive(false);
                dialogue.SetActive(true);
            }
            else {
                Debug.Log("finish - call finish video");
                Application.LoadLevel("GoodFinal");

            }
            
        }
        else {
            Debug.Log("finish - call bad finish video");
            Application.LoadLevel("BadFinal");
        }
        
    }
}
