using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class DailyQuestData 
{
    public string title;
    public Sprite icon;
    public QuestType questType;
}
public enum QuestType
{
    DailyQuest,
    Challage
}
