using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldChanger : MonoBehaviour
{

    private TMP_InputField inputField;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    // Change Jump Speed Value
    public void ChangeJumpSpeed()
    {
        string stringValue = inputField.text;
        float floatValue = float.Parse(stringValue);
        Debug.Log("PLAYER COLOR : " + floatValue);
        PlayerData.Instance.playerJumpSpeed = floatValue;
    }

    // Change Player Scale
    public void ChangePlayerScale()
    {
        string stringValue = inputField.text;
        float floatValue = float.Parse(stringValue);
        Debug.Log("PLAYER SCALE : " + floatValue);
        PlayerData.Instance.playerScale = new Vector3(floatValue,floatValue);
    }


}
