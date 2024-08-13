using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DailyQuestItemHandler : MonoBehaviour
{
    public DailyQuestData dailyQuestData;
    public void SetData(DailyQuestData dailyQuestData)
    {
        Debug.Log("SetData");
        this.dailyQuestData = dailyQuestData;
        UpdateUi();
    }
    public void UpdateUi()
    {

    }
}