using UnityEngine;
using TMPro;

public class SkillScroll : MonoBehaviour
{
    // set variables
    public Skill skill;
    public TMP_Text skillNameText;
    public TMP_Text skillDescText;

    bool learned;
    bool unlocked;

    public GameObject skillInfoPanel;
    RectTransform rectTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rectTransform = skillInfoPanel.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
