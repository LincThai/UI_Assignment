using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Scriptable Objects/Skill")]
public class Skill : ScriptableObject
{
    public string skillName;
    public string skillDescription;
    public int skillCost;
    public bool unlocked;
    public bool learned = false;
    public SkillType skillType;

    [Flags]
    public enum SkillType
    {
        None = 0,
        sword = 1,
        blade = 2,
        spear = 4,
        archery = 8,
        body = 16,
        boxing = 32,
    }
}
