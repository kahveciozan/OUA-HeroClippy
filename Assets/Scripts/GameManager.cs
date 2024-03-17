
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int gameLevel = 0;

    public Image cursor;
   // public int collectableCount;

   // public TextMeshProUGUI tmp_gameLevel;
  //  public TextMeshProUGUI tmp_collectableCount;





    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        if (gameLevel == 0)
        {
            //SceneManager.LoadScene(0);
        }

        else if (gameLevel == 1)
        {

        }

        else if (gameLevel == 2)
        {

        }

        else if (gameLevel == 3)
        {

        }

    }

    void Update()
    {
        //tmp_gameLevel.text = "LEVEL : " + gameLevel;
       // tmp_collectableCount.text = "" + collectableCount;
       if(Input.GetKeyDown(KeyCode.Space))
       {
          Debug.Log(Input.mousePosition);

       }

          cursor.transform.position = new Vector2(Input.mousePosition.x , Input.mousePosition.y);

    }


   

    public void Death()
    {
        Debug.Log("ara");
       SceneManager.LoadScene(gameLevel);
    }


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
