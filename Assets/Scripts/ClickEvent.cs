using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    public Button Button;
    public UIScore Score;

    public int getGold = 1;
    public void OnClickButton()
    {
        GetGold(getGold);
        Score.times ++;
        //Debug.Log("click");
    }

    public void GetGold(int amount)
    {
        Score.gold += amount;
    }
}


