using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownValueChanger : MonoBehaviour
{
    private Dropdown dropdown;

    private void Start()
    {
        dropdown = GetComponent<Dropdown>();
    }

    // Change the value of the jumpable
    public void GetDropdownValue()
    {
        //string value = dropdown.value;

        if (value == "false")
        {
            PlayerData.Instance.isJumpable = false;
        }
        else
        {
            PlayerData.Instance.isJumpable = true;
        }
    }
}
