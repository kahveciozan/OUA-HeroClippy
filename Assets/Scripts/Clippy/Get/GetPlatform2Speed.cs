using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetPlatform2Speed : MonoBehaviour
{
    private TMP_InputField jumpForceInputField;

    private void Start()
    {
        jumpForceInputField = GetComponent<TMP_InputField>();

        InityPlatform2Speed();
    }

    void InityPlatform2Speed()
    {
        jumpForceInputField.text = PlayerData.Instance.platformSpeed2.ToString();
    }
}
