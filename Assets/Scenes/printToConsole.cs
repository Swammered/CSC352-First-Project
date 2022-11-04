using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printToConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey i am printing to the console.");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,0.1f);
        transform.Translate(0.01f,0,0);
    }
}
