using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInSeconds : MonoBehaviour
{
    public float secondsUntilDestruction;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, secondsUntilDestruction);
    }
}
