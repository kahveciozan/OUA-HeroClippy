using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetPlatform2Direction : MonoBehaviour
{
    private TMP_InputField jumpForceInputField;

    private void Start()
    {
        jumpForceInputField = GetComponent<TMP_InputField>();

        InityPlatform2Direction();
    }

    void InityPlatform2Direction()
    {
        //jumpForceInputField.text = PlatformManager.Instance.platform2Direction.ToString();
    }
}
