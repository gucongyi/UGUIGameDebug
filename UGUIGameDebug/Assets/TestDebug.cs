using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello");
        Debug.LogWarning("Hello");
        Debug.LogError("Hello");
        Debug.Assert(1==2);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
