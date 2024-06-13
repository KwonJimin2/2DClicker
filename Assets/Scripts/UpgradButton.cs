using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UpgradButton : MonoBehaviour
{
    public UIScore Score;
    public ClickEvent ClickEvent;

    int hasGold_GU = 1000;
    int hasGold_AC = 10000;
    bool autoclick = false;


    public void GetGoldUpgradeButton()
    {
        if (Score.gold >= hasGold_GU && ClickEvent.getGold <= 2048)
        {
            Score.gold -= hasGold_GU;
            ClickEvent.getGold += ClickEvent.getGold;
            hasGold_GU += hasGold_GU;
        }
        else if (ClickEvent.getGold >= 2049) Debug.Log("모든 업그레이드가 완료되었습니다.");
        else Debug.Log("골드가 부족합니다.");
        
    }

    public void GetAutoClickButton()
    {
        if (Score.gold >= hasGold_AC && autoclick == false)
        {
            Score.gold -= hasGold_AC;
            autoclick = true;
            StartCoroutine(AutoClick(0.5f));
        }
        else if (autoclick == true) Debug.Log("이미 구매된 아이템입니다.");
        else Debug.Log("골드가 부족합니다.");
    }

    IEnumerator AutoClick(float amount)
    {
        while (true)
        {
            yield return new WaitForSeconds(amount);
            ClickEvent.OnClickButton();
        }
    }
}
