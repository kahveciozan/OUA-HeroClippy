using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClippyManager : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;
    private RectTransform tablet;
    [SerializeField] private Vector2 tabletAppearPosition;
    [SerializeField] private Vector2 tabletDisappearPosition;

    [SerializeField] GameObject openButton;
    [SerializeField] CanvasGroup background;

    private void Start()
    {
        tablet = GetComponent<RectTransform>();
    }

    public void AppearTablet(float yPos)
    {
        m_Animator.SetBool("clippyUp", true);
        //tablet.anchoredPosition = new Vector2(tablet.anchoredPosition.x, yPos);
        openButton.SetActive(false);
        background.alpha= 0.8f;
    }

    public void DisappearTablet(float yPos)
    {
        m_Animator.SetBool("clippyUp", false);
        background.alpha = 0;
        //tablet.anchoredPosition = new Vector2(tablet.anchoredPosition.x, yPos);
        StartCoroutine(WaitForAnimation());
    }

    IEnumerator WaitForAnimation()
    {
        yield return new WaitForSeconds(0.8f);
        openButton.SetActive(true);
        RestartTheScene();

    }


    // Restart Active Scene
    public void RestartTheScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
