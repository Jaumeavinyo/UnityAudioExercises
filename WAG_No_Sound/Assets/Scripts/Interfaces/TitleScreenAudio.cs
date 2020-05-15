using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenAudio : MonoBehaviour
{

    public AudioClip Music;

    [Range(0,1)]
    public float volume_ = 1;

    private AudioSource source { get { return GetComponent<AudioSource>(); } }


    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = Music;
        source.playOnAwake = false;
        source.loop = true;
        source.volume = volume_;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
