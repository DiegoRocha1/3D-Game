using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public static int pointVal = 0;
    Text points;

	// Use this for initialization
	void Start () {
        points = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        points.text = "Score : " + pointVal;
	}
}
