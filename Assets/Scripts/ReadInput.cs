using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    private string input;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
