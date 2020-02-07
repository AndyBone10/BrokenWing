using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    public AudioSource bounce;
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Owl")
        {
            SoundManager.PlaySound("bounce");
        }
    }
}
