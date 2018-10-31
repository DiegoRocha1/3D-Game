using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    
    public GameObject bad;
    public GameObject portal;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void OnParticleCollision(GameObject other)
    {
        if(other == bad){
            Debug.Log("WORKS");
        }

        if(other == portal){
            portal.transform.position = new Vector3(Random.Range(-33.0f, 36.0f), -4.0f, Random.Range(-87.0f, 83.0f));
        }
    }
}
