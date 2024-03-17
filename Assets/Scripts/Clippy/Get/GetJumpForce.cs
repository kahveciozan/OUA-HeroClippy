using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetJumpForce : MonoBehaviour
{
    private TMP_InputField jumpForceInputField;

    private void Start()
    {
        jumpForceInputField = GetComponent<TMP_InputField>();
        InitJumpForce();
    }

    private void InitJumpForce()
    {
        jumpForceInputField.text = PlayerData.Instance.playerJumpSpeed.ToString();
    }
}
