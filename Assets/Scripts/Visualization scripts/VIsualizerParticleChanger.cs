using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIsualizerParticleChanger : MonoBehaviour
{
    public ParticleSystem originalPs;
    public ParticleSystem newPs;
    public CattleSmallCatac fossilNews;

    // Update is called once per frame
    void Update()
    {
        var emissionO = originalPs.emission;
        var emissionN = newPs.emission;

        if (fossilNews.biogasIsActivated == false)
        {
            emissionO.enabled = !fossilNews.biogasIsActivated;
            emissionN.enabled = fossilNews.biogasIsActivated;
        }

        else if (fossilNews.biogasIsActivated == true)
        {
            emissionO.enabled = !fossilNews.biogasIsActivated;
            emissionN.enabled = fossilNews.biogasIsActivated;
        }
    }
}
