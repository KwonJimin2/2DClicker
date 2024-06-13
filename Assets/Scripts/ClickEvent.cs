using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    public Button Button;

    bool AutoClickOn = false;
    public void OnClickButton()
    {
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


