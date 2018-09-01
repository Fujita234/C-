using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("HelloWorld");
        Person person = new Person();
        Debug.Log(person.show("やったぜ。", "投稿者変態糞土方、", "8月25日午後2時をおつたえするぜ"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Person {

    public string first;
    public string second;
    public string third;

    public string show(string first, string second, string third) {

        return first + second + third;
    }

}

