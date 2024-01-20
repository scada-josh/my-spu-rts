using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int a;
    float b;
    string c;
    char d;
    bool e;

    // Start is called before the first frame update
    void Start()
    {
        int a = 2;
        int b = 3;

        if(a>b){
            Debug.Log("Hello");
        } else if (b ==3 ) {
        Debug.Log("Bye");
        } else {
            Debug.Log("xxx");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
