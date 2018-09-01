using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        int n = 3;
        if (n > 5)
        {
            Debug.Log("ふとすぎるっぴ");
        }
        else
        {
            Debug.Log("細すぎるっぴ");
        }
    }

    // Update is called once per frame
    void Update() {
        int n = 4;
        bool result;
        result = (n < 3) ? true : false;
        Debug.Log(result);
    }
}