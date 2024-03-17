using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Platform : MonoBehaviour
{

    
    

    private Animator anim;

    void Start()
    {

        anim = GetComponent<Animator>();
        anim.speed = 1;

    }

    void Update()
    {

        if (PlayerData.Instance.platformDirection1 == "Horizontal")
        {
            anim.SetBool("horizontal", true);
            anim.SetBool("vertical", false);

        }

        else if (PlayerData.Instance.platformDirection1 == "Vertical")
        {
            anim.SetBool("horizontal", false);
            anim.SetBool("vertical", true);
        }

    

        anim.speed = PlayerData.Instance.platformSpeed1 / 10;

    }


    




}
