using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Load(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
