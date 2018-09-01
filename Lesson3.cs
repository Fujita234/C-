using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int n = 0;
        int i = 0;
        while (n < 9) {
            n = Random.Range(0, 10);
            Debug.Log(n);
            i++;
        }
        Debug.Log("10が出るのに" + i + "回かかりました");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
