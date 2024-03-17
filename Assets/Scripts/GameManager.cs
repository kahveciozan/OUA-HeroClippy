
using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int gameLevel = 0;

    public Image cursorParent, cursorIdle, cursorRight, cursorLeft;
    // public int collectableCount;

    // public TextMeshProUGUI tmp_gameLevel;
    //  public TextMeshProUGUI tmp_collectableCount;





    void Awake()
    {
        instance = this;
    }


    void Start()
    {

        Cursor.visible = false;

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




        if (Input.GetAxis("Mouse X") > 0)
        {

            cursorParent.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y - 45f);

            cursorRight.gameObject.SetActive(true);
            cursorLeft.gameObject.SetActive(false);
            cursorIdle.gameObject.SetActive(false);


        }

        else if (Input.GetAxis("Mouse X") < 0)
        {

            cursorParent.transform.position = new Vector2(Input.mousePosition.x + 15, Input.mousePosition.y - 45f);

            cursorRight.gameObject.SetActive(false);
            cursorLeft.gameObject.SetActive(true);
            cursorIdle.gameObject.SetActive(false);
        }



    }




    public IEnumerator Death()
    {
        //SceneManager.LoadScene(gameLevel);

        yield return new WaitForSeconds(3);
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
