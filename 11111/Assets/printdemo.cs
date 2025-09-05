using JetBrains.Annotations;
using UnityEngine;

public class printdemo : MonoBehaviour
{
    public GameObject cubeObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubeObj = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
