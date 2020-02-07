using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OwlController : MonoBehaviour {

	private Rigidbody2D theRigidbody;
	private Animator theAnim;

    public AudioSource flapOne;
    public AudioSource flapTwo;

	public float upForce;
	public float rotSpeed;

    private int soundSwitch = 0;
	//public GameObject pointOfForce;
	// Use this for initialization
	void Start () {
		theRigidbody = GetComponent<Rigidbody2D>();	
		theAnim = GetComponent<Animator>();
        theRigidbody.Sleep();
	}
	
	// Update is called once per frame
	void Update () {
	
		

		if ((Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)) && GameManager.instance.gameStarted)
		{
            theRigidbody.WakeUp();
            theRigidbody.velocity = Vector2.zero;
           		theRigidbody.AddForce(transform.up * upForce);
           		theRigidbody.MoveRotation(theRigidbody.rotation - rotSpeed * Time.fixedDeltaTime);
           		theAnim.SetTrigger("Flap");

            if (soundSwitch == 0)
            {
                flapOne.Play();
                soundSwitch = 1;
            }
            else {
                flapTwo.Play();
                soundSwitch = 0;
            }
		}
	}
}
