using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowController : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float moveSpeed;
    public bool moveLeft;
    public bool moveRight;

    public AudioSource crowSound;

    void Start()
    {
        crowSound = GameObject.Find("crow").GetComponent<AudioSource>();
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
    }

    void Update()
    {
        if (moveLeft)
        {
            m_Rigidbody.velocity = -transform.right * moveSpeed;
        }

        if (moveRight) {
            m_Rigidbody.velocity = transform.right * moveSpeed;

        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Owl")
        {
            SoundManager.PlaySound("crow");

        }
    }
}