using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FadeInGUI : MonoBehaviour {


    void Start()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();

        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / 2;
            yield return null;
        }

        ListNpcScript.addNpc(transform.root.gameObject);
        List<GameObject> npcs = ListNpcScript.getNpcs();
        foreach(GameObject go in npcs){
            Debug.Log("NPC: "+go.name);
        }

        GameObject ob = ListNpcScript.getNpc("NPC");

        if (ob != null)
            Debug.Log("Search: "+ob.name);

        yield return null;
    }
}
