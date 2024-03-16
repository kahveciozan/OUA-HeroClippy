using System.Collections;
using System.Collections.Generic;
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
    public void GetDropdownValue()
    {
        PlayerData.Instance.isJumpable = dropdown.value == 0 ? false : true;
        Debug.Log("PLAYER JUMPABLE : " + PlayerData.Instance.isJumpable);
    }
}
