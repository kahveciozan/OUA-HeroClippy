using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetInputValues : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputA;
    [SerializeField] private TextMeshProUGUI inputD;
    [SerializeField] private TextMeshProUGUI inputW;


    private void Start()
    {
        InitInputValues();
    }

    private void InitInputValues()
    {
        inputA.text = PlayerData.Instance.A.ToString();
        inputD.text = PlayerData.Instance.D.ToString();
        inputW.text = PlayerData.Instance.W.ToString();
    }
}
