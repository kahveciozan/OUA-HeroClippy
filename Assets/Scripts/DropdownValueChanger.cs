
using UnityEngine;
using TMPro;

public class DropdownValueChanger : MonoBehaviour
{
    private TMP_Dropdown dropdown;

    private void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }

    // Change the value of the jumpable
    public void ChangeJumpableValue()
    {
        PlayerData.Instance.isJumpable = dropdown.value == 0 ? false : true;
        Debug.Log("PLAYER JUMPABLE : " + PlayerData.Instance.isJumpable);
    }

    // Change player color
    public void ChangePlayerColor()
    {
        string colorName = dropdown.options[dropdown.value].text;
        Color color = Color.white;
        switch (colorName)
        {
            case "Color.Red":
                color = Color.red;
                break;
            case "Color.Green":
                color = Color.green;
                break;
            case "Color.Blue":
                color = Color.blue;
                break;
            case "Color.Yellow":
                color = Color.yellow;
                break;
            case "Color.White":
                color = Color.white;
                break;
            case "Color.Black":
                color = Color.black;
                break;
        }
        PlayerData.Instance.playerColor = color;
        Debug.Log("PLAYER COLOR : " + color);
    }
}
