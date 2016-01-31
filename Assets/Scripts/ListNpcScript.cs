using UnityEngine;
using System.Collections.Generic;

public class ListNpcScript : MonoBehaviour {

    public static List<GameObject> npcs;
    public GameObject questioner;
    public static GameObject quest;

    public static bool isShowed = false;

    void Start(){
        npcs = new List<GameObject>();
        isShowed = false;
        quest = questioner;
    }

    public static List<GameObject> getNpcs() {
        return npcs;
    }

    public static void addNpc(GameObject npc) {
        npcs.Add(npc);

    }

    public static void checkFinalQuestion()
    {
        if (npcs.Count >= 1)
        {
            if (!isShowed)
            {
                isShowed = true;
                quest.SetActive(true);
                //CameraControl.StartStop(true);

            }
        }
    }
    public static GameObject getNpc(string name) {
        GameObject ob = null;
        foreach (GameObject go in npcs)
        {
            if (go.name.Equals(name)) {
                ob = go;
            }
        }
        return ob;
    }
}
