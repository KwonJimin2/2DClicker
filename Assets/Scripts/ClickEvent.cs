using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    public Button Button;
    public UIScore Score;
    public Particle particle;
    public AudioClip clip;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public int getGold = 1;
    public void OnClickButton()
    {
        audioSource.PlayOneShot(clip);
        GetGold(getGold);
        Score.times ++;
        particle.ClickParticle();
        //Debug.Log("click");
    }

    public void GetGold(int amount)
    {
        Score.gold += amount;
    }
}


