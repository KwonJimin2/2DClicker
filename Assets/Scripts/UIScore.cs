using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public TextMeshProUGUI Gold;
    public TextMeshProUGUI Times;

    public int gold;
    public int times;

    public void GoldUpdate()
    {
        Gold.text = "Gold : " + gold ;
    }

    public void TimesUpdate()
    {
        Times.text = times + " Times";
    }

    void Update()
    {
        GoldUpdate();
        TimesUpdate();
    }

}
