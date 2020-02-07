using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour {

	public GameObject startPoint;
	public GameObject endPoint;
	public GameObject apple;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.instance.gameStarted)
        {
            float spawnPoint = Random.Range(startPoint.transform.position.x, endPoint.transform.position.x);
            int r = Random.Range(1, 20);
            if (r == 10)
            {
                Instantiate(apple, new Vector3(spawnPoint, this.transform.position.y + 70, transform.position.z), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            }
        }
	}
}
