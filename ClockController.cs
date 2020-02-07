using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{

    private Animator clockAnimator;
    private float destroyTime = 10.0f;
    void Start()
    {
        clockAnimator = this.gameObject.GetComponent<Animator>();
        Destroy(this.gameObject, destroyTime);
    }

    private void Update()
    {
        destroyTime -= Time.deltaTime;
        clockAnimator.SetFloat("ClockExistTime", destroyTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Owl")
        {
            SoundManager.PlaySound("powerup");
            ScoreController.instance.AddScore(10);
            Destroy(this.gameObject);
        }
    }

}
