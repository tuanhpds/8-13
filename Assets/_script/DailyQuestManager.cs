using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyQuestManager : MonoBehaviour
{
    public QuestDataBase questDataBase;
    public DailyQuestItemHandler dailyQuestItemHandler;
    public Transform rootUiContent;
    // Start is called before the first frame update
    private void Start()
    {
        foreach(var questData in questDataBase.questData)
        {
            CreatQuest(questData);
        }
    }
    private void CreatQuest(DailyQuestData questData)
    {
        var quest = Instantiate(dailyQuestItemHandler, rootUiContent);
        quest.SetData(questData);
    }
}
