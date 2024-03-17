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

        if(floatValue < 1) floatValue = 1;
        if(floatValue > 30) floatValue = 30;

        Debug.Log("PLAYER SCALE : " + floatValue);
        PlayerData.Instance.playerScale = new Vector3(floatValue,floatValue);
    }

    //Change Platform Speed
    public void ChangePlatformSpeed()
    {
        string stringValue = inputField.text;
        Debug.Log("PLATFORM 1 Speed : " + stringValue);

        //PlatformManager.Instance.platformSpeed = floatValue;
    }


    //Cahange Platform 1 Direction
    public void ChangePlatform1Direction()
    {
        string stringValue = inputField.text;
        Debug.Log("PLATFORM 1 DIRECTION : " + stringValue);
        //PlatformManager.Instance.platform1Direction = floatValue;
    }

    //Change Platform 2 Direction
    public void ChangePlatform2Direction()
    {
        string stringValue = inputField.text;
        Debug.Log("PLATFORM 2 DIRECTION : " + stringValue);
        //PlatformManager.Instance.platform2Direction = floatValue;
    }

}
