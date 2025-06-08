using UnityEngine;
using TMPro;
using DG.Tweening;

public class SkillScroll : MonoBehaviour
{
    // set variables
    public Skill skill;
    public TMP_Text skillNameText;
    public TMP_Text skillTypeText;
    public TMP_Text skillCostText;
    public TMP_Text skillDescText;

    bool learned;
    bool unlocked;

    public GameObject skillInfoPanel;
    RectTransform rectTransform;
    Vector2 startPos;
    Vector2 endPos = new Vector2(0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get the rect transform and assign to variable
        rectTransform = skillInfoPanel.GetComponent<RectTransform>();
        // assign variable for starting position using the current local position
        startPos = rectTransform.localPosition;
    }

    public void PanelMoveOpen(float time)
    {
        // activate the panel
        skillInfoPanel.SetActive(true);
        // change text
        skillNameText.text = skill.name;
        skillCostText.text = "Cost: " + skill.skillCost.ToString();
        skillDescText.text = "Skill Type: " + skill.skillTypes.ToString();
        skillDescText.text = skill.skillDescription;
        // play audio
        FindObjectOfType<AudioManager>().Play("OpenCloseScroll");
        // the animation with easing
        rectTransform.DOAnchorPos(endPos, time, false).SetEase(Ease.OutBounce);
    }

    public void PanelMoveClose(float time)
    {
        // play audio
        FindObjectOfType<AudioManager>().Play("OpenCloseScroll");
        // the animation with easing
        rectTransform.DOAnchorPos(startPos, time, false).SetEase(Ease.InOutSine);
    }
}
