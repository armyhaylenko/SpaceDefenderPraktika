using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    [SerializeField] float delayInSeconds = 2f;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadCross()
    {
        SceneManager.LoadScene(2);
        FindObjectOfType<GameSession>().ResetGame();
    }


    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGame2()
    {
        SceneManager.LoadScene(3);
        FindObjectOfType<GameSession>().ResetGame();
    }
    
    public void LoadGame3()
    {
        new WaitForSeconds(3);
        SceneManager.LoadScene(4);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGame4()
    {
        SceneManager.LoadScene(5);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGame5()
    {
        SceneManager.LoadScene(6);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
