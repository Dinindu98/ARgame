using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject menu;
    public GameObject game;
    public GameObject endscreen;
    // Start is called before the first frame update
    void Start()
    {
        gameMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameMenu()
    {
        menu.SetActive(true);
        game.SetActive(false);
        endscreen.SetActive(false);
    }

    public void gameplay()
    {
        menu.SetActive(false);
        game.SetActive(true);
        endscreen.SetActive(false);
    }

    public void gameend()
    {
        menu.SetActive(false);
        game.SetActive(false);
        endscreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
