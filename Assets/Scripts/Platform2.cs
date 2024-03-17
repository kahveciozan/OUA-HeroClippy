using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
   
    private Animator anim;

    void Start()
    {

        anim = GetComponent<Animator>();
        anim.speed = 1;

    }

    void Update()
    {

        if (PlayerData.Instance.platformDirection2 == "Horizontal")
        {
            anim.SetBool("horizontal", true);
            anim.SetBool("vertical", false);

        }

        else if (PlayerData.Instance.platformDirection2 == "Vertical")
        {
            anim.SetBool("horizontal", false);
            anim.SetBool("vertical", true);
        }

    

        anim.speed = PlayerData.Instance.platformSpeed2;

    }
}
