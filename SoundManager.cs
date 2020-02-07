using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip bounce;
    public static AudioClip crow;
    public static AudioClip powerup;

    private static AudioSource audioSource;

    private void Start()
    {
        bounce = Resources.Load<AudioClip>("bounce");
        crow = Resources.Load<AudioClip>("crow");
        powerup = Resources.Load<AudioClip>("powerup");
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip) {
        switch (clip) {
            case "bounce":
                audioSource.PlayOneShot(bounce);
                break;
            case "crow":
                audioSource.PlayOneShot(crow);
                break;
            case "powerup":
                audioSource.PlayOneShot(powerup);
                break;

        }
    }

}
