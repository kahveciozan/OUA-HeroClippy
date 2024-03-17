using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerColor : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dropdown;


    private void Start()
    {
        InitPlayerColor();
    }

    private void InitPlayerColor()
    {
        Color color = PlayerData.Instance.playerColor;
        string colorString = "Color.White";

        if (color == Color.red)
        {
            colorString = "Color.Red";
        }
        else if (color == Color.green)
        {
            colorString = "Color.Green";
        }
        else if (color == Color.blue)
        {
            colorString = "Color.Blue";
        }
        else if (color == Color.yellow)
        {
            colorString = "Color.Yellow";
        }
        else if (color == Color.white)
        {
            colorString = "Color.White";
        }
        else if (color == Color.black)
        {
            colorString = "Color.Black";
        }

        dropdown.text = colorString;

    }
}
