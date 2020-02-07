using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomSpikeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Owl") {
            Debug.Log("hELLO");
            other.gameObject.SetActive(false);
            GameManager.instance.gameOver = true;
        }

        if (other.gameObject.tag == "Apple")
        {
            Destroy(other.gameObject);
        }
    }
}
