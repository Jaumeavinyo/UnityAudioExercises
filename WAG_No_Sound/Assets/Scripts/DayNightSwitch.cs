using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightSwitch : MonoBehaviour
{
   AudioSource ASource;
    public AudioClip day_audio;
    public AudioClip night_audio;

    public DayNightCycle sunScript;
    public bool day;

    void Awake()
    {
         
    }

    void OnEnable()
    {
       
    }

    void OnDisable()
    {
        
    }

    void NightSwitch()
    {
        if (!day)
        {
            ASource.clip = night_audio;

        }
        else if (day) {

            ASource.clip = day_audio;

        }

    }

 
}
