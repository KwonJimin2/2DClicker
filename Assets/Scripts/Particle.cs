using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{

    public void ClickParticle()
    {
            ParticleSystem particleSystem = GameManager.Instance.EffectParticle;
            particleSystem.Play();
    }
}
