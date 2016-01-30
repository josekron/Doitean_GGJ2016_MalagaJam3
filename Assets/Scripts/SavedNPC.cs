using UnityEngine;
using System.Collections.Generic;

public class SavedNPC : MonoBehaviour
{

    private List<GameObject> saved;
    // Use this for initialization
    void Start()
    {
        saved = new List<GameObject>();
    }

    public void SaveNPC(GameObject npc)
    {
        saved.Add(npc);
    }

    public void DeleteAll()
    {
        foreach (GameObject npc in saved)
        {
            Destroy(npc);
        }
    }
}
