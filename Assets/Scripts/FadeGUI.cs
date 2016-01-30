using UnityEngine;
using System.Collections;

public class FadeGUI : MonoBehaviour {

    public void FadeMe() {
        /*GameObject father = transform.root.gameObject;

        FadeNpc scriptFadeNpc = father.GetComponent<FadeNpc>();
        scriptFadeNpc.activateFade();*/

        StartCoroutine(DoFade());
    }

    IEnumerator DoFade() {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();

        while (canvasGroup.alpha > 0) {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        //GameObject father = transform.root.gameObject;
        GameObject npc = this.transform.Find("npc1").gameObject;

        FadeNpc scriptFadeNpc = npc.GetComponent<FadeNpc>();
        scriptFadeNpc.activateFade();

        canvasGroup.interactable = false;

        

        //father.SetActive(false);
        yield return null;
    }
}
