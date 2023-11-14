using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip walksound, papercollectsound, damagesound;
    static AudioSource audiosource; 
    void Start()
    {
        walksound = Resources.Load<AudioClip>("walk");
        papercollectsound = Resources.Load<AudioClip>("paper");
        damagesound = Resources.Load<AudioClip>("damage");
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
        case "walk":
                audiosource.PlayOneShot(walksound);
                break;
        case "paper":
                audiosource.PlayOneShot(papercollectsound);
                break;
        case "damage":
                audiosource.PlayOneShot(damagesound);
                break;
        }
    }
}
