using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    private GameObject credits, menu;
    // Use this for initialization
    void Start()
    {
        menu = GameObject.Find("CanvasMenu");
        credits = GameObject.Find("CanvasCredits");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowCredits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }

    public void CloseCredits()
    {
        credits.SetActive(false);
        menu.SetActive(true);
    }

    public void ShowControls()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
