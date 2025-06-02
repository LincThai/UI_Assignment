using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PanelAnimate : MonoBehaviour
{
    private Vector2 startPos;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.localPosition;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void PanalMoveUp(float time)
    {
        canvasGroup.alpha = 0f;
        //rectTransform.DOAnchorPos();

    }
}
