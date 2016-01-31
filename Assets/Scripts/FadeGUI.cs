using UnityEngine;
using System.Collections;

public class FadeGUI : MonoBehaviour {

    public void FadeMe() {
        /*GameObject father = transform.root.gameObject;

        FadeNpc scriptFadeNpc = father.GetComponent<FadeNpc>();
        scriptFadeNpc.activateFade();*/
        Debug.Log("FadeGUI - FadeMe()");
        GameObject father = transform.root.gameObject;
        AudioSource[] audioSources = father.GetComponents<AudioSource>();
        audioSources[1].Play();
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade() {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();

        while (canvasGroup.alpha > 0) {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        GameObject father = transform.root.gameObject;
        Debug.Log("father: " + father.name);
        GameObject npc = father.transform.Find("spriteNpc").gameObject;
        Debug.Log("npc: " + npc.name);

        if (npc == null)
            Debug.Log("cuervo not found");
        else
            Debug.Log("cuervo found: " + npc.name);

        FadeNpc scriptFadeNpc = npc.GetComponent<FadeNpc>();
        scriptFadeNpc.activateFade();

        canvasGroup.interactable = false;
        ListNpcScript.checkFinalQuestion();

        Destroy(father);
        //father.SetActive(false);
        yield return null;
    }
}
