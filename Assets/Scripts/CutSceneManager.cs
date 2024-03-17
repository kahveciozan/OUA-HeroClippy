using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{
    [SerializeField] private GameObject clippy;
    [SerializeField] private GameObject clippyCutScenes;
    [SerializeField] private GameObject characterController;
    private static bool isFirstDie = false;


    [SerializeField] GameObject gameDesigner;
    [SerializeField] GameObject dialog1;
    [SerializeField] GameObject dialog2;
    [SerializeField] GameObject dialog3;
    [SerializeField] GameObject dialog4;
    [SerializeField] GameObject dialog5;
    [SerializeField] GameObject dialog6;
    [SerializeField] GameObject dialog7;

    [SerializeField] GameObject clickyRight;
    [SerializeField] GameObject clickyMid;
    [SerializeField] GameObject clickyLeft;
    // Start is called before the first frame update
    void Start()
    {
        clippy.SetActive(false);
        if (!isFirstDie)
        {
            isFirstDie = true;
            CharacterController.CutSceneStart += GameDesignerAnimStart;
            Debug.Log("CUTSCENE START");
        }
        else
        {
            //GameManager.instance.Death();
            
            clippy.SetActive(true);
        }
    }

    private void GameDesignerAnimStart() 
    {
        Debug.Log("CUTSCENE GAME DESIGER");

        //characterController.SetActive(false);

        gameDesigner.SetActive(true);
        dialog1.SetActive(true);
    }

    public void Dialog2()
    {
        Debug.Log("CUTSCENE DIALOG 2");
        dialog1.SetActive(false);
        dialog2.SetActive(true);
    }

    public void Dialog3()
    {
        Debug.Log("CUTSCENE DIALOG 3");
        dialog2.SetActive(false);
        dialog3.SetActive(true);
        clickyRight.SetActive(true);
    }

    public void Dialog4()
    {
        Debug.Log("CUTSCENE DIALOG 4");
        dialog3.SetActive(false);
        dialog4.SetActive(true);
    }

    public void Dialog5()
    {
        Debug.Log("CUTSCENE DIALOG 5");
        dialog4.SetActive(false);
        dialog5.SetActive(true);
        clickyMid.SetActive(true);
        clickyRight.SetActive(false);
    }

    public void Dialog6()
    {
        Debug.Log("CUTSCENE DIALOG 6");
        dialog5.SetActive(false);
        dialog6.SetActive(true);
        clippyCutScenes.SetActive(true);

    }

    public void Dialog7()
    {
        Debug.Log("CUTSCENE DIALOG 7");
        dialog6.SetActive(false);
        dialog7.SetActive(true);
        clickyMid.SetActive(false);
        clickyLeft.SetActive(true);
        clippyCutScenes.SetActive(false);

    }

    public void TurnToGame()
    {
        gameDesigner.SetActive(false);
        dialog7.SetActive(false);
        clippy.SetActive(true);
        GameManager.instance.Death();

    }
}
