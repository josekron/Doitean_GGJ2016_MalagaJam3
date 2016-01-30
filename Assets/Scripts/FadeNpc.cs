using UnityEngine;
using System.Collections;

public class FadeNpc : MonoBehaviour {

    private SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
        sprite = this.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void activateFade()
    {
        Debug.Log("a fadear!");
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade() {

        while (sprite.color.a > 0) {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a -Time.deltaTime / 2);
            yield return null;
        }
        yield return null;
    }
}
