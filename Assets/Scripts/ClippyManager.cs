using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClippyManager : MonoBehaviour
{
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
        tablet.anchoredPosition = new Vector2(tablet.anchoredPosition.x, yPos);
        openButton.SetActive(false);
        background.alpha= 0.8f;
    }

    public void DisappearTablet(float yPos)
    {
        background.alpha = 0;
        tablet.anchoredPosition = new Vector2(tablet.anchoredPosition.x, yPos);
        openButton.SetActive(true);
    }
}
