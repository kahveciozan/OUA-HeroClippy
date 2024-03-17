using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetPlatform1Direction : MonoBehaviour
{
    private TMP_InputField jumpForceInputField;

    private void Start()
    {
        jumpForceInputField = GetComponent<TMP_InputField>();

        InityPlatform1Direction();

    }

    void InityPlatform1Direction()
    {
        jumpForceInputField.text = PlayerData.Instance.platformDirection1;
    }
}
