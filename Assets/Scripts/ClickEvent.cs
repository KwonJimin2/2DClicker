using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    public Button Button;
    public UIScore Score;

    bool AutoClickOn = false;
    public void OnClickButton()
    {
        Score.gold += 1;
        Score.times ++;
        Debug.Log("click");
    }
    
    public void GetAutoClick(float amount)
    {
        StartCoroutine(AutoClick(amount));
    }

    IEnumerator AutoClick(float amount)
    {
        while (AutoClickOn == true)
        {
            yield return new WaitForSeconds(amount);
            OnClickButton();
        }
    }
}


