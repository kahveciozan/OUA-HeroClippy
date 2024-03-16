
using UnityEngine;

public class JumpCollider : MonoBehaviour
{   

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "zemin")
        {
            PlayerData.Instance.isJumpable = true;
        }

        
    }

    void OnTriggerStay2D(Collider2D other)
    {
          if (other.tag == "zemin")
        {
            PlayerData.Instance.isJumpable = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "zemin")
        {

            PlayerData.Instance.isJumpable = false;
        }
    }
}
