
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public bool isWrongSide = true;
    public bool isJumpable = false;
    public int collectibleCount;

    public float playerSpeed;
    public float playerJumpSpeed;
    public Vector2 playerScale;

    public Color playerColor;

    public static PlayerData Instance;

    private GameObject character;

    public KeyCode A, D, W;

    public float platformSpeed1;
    public string platformDirection1;
    public float platformSpeed2;

    public string platformDirection2;






    private void Awake()
    {
        character = GameObject.FindGameObjectWithTag("Character");

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        playerColor = character.GetComponent<CharacterController>().spriteRenderer.color;
    }




}
