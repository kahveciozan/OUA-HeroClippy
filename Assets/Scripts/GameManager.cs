
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int gameLevel = 0;
    public int collectableCount;

    public TextMeshProUGUI tmp_gameLevel;
    public TextMeshProUGUI tmp_collectableCount;





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
        tmp_gameLevel.text = "LEVEL : " + gameLevel;
        tmp_collectableCount.text = "" + collectableCount;

    }


    public void Win()
    {

    }

    public void Lose()
    {

    }


}
