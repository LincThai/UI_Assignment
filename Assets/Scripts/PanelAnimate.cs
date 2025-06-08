using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PanelAnimate : MonoBehaviour
{
    private Vector2 startPos;
    private CanvasGroup canvasGroup; // for fade
    private RectTransform rectTransform;
    [SerializeField] Vector2 endPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.localPosition;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void PanelMoveUp(float time)
    {
        canvasGroup.alpha = 0f;
        rectTransform.DOAnchorPos(endPos, time, false).SetEase(Ease.OutBounce);
        canvasGroup.DOFade(1f, time);
    }

    public void PanelMoveDown(float time)
    {
        rectTransform.DOAnchorPos(startPos, time, false).SetEase(Ease.InOutSine);
        canvasGroup.DOFade(0f, time);
    }

    public void PanelMove(float time)
    {
        if (rectTransform.localEulerAngles == new Vector3(startPos.x, startPos.y, 0))
        {
            rectTransform.DOAnchorPos(endPos, time, false).SetEase(Ease.OutBounce);
        }
        else
        {
            rectTransform.DOAnchorPos(startPos, time, false).SetEase(Ease.OutBounce);
        }
    }
}
