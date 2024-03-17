using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScale : MonoBehaviour
{
    private TMP_InputField inputField;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        InitScaleValue();
    }

    public void InitScaleValue()
    {
        inputField.text = PlayerData.Instance.playerScale.x.ToString();
    }
}
