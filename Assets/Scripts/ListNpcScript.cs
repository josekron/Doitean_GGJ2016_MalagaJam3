using UnityEngine;
using System.Collections.Generic;

public class ListNpcScript : MonoBehaviour {

    public static List<GameObject> npcs;

    void Start(){
        npcs = new List<GameObject>();
    }

    public static List<GameObject> getNpcs() {
        return npcs;
    }

    public static void addNpc(GameObject npc) {
        npcs.Add(npc);
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
