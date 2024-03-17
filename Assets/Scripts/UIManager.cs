using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int gameLevel = 0;

    // Go to next level
    public void NextLevel()
    {
        gameLevel++;
        SceneManager.LoadScene(gameLevel);
    }

    //Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
