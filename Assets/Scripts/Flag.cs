
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Character"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            GameManager.instance.gameLevel += 1;
            Debug.Log("NEXT LEVEL");
        }

        Debug.Log("NEXT LEVEL 2");

    }


}
