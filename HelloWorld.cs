using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HelloWorld : MonoBehaviour
{
    public Color color;
    void ChangeColor(Color c) {
        GetComponent<Renderer>().material.color = c;
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor(color);
        
        print("Hello, World!");
    }
   
    // Update is called once per frame
    void Update()
    
    {
      


       

    }
}
