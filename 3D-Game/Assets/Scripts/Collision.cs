using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour {
    
    public GameObject bad;
    public GameObject portal;

    public AudioSource tires;
    public AudioSource explosion;
    public AudioSource success;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown){
            tires.Play();
        }
	}

    public void OnParticleCollision(GameObject other)
    {
        if(other == bad){
            SceneManager.LoadScene("EndScreen");
            explosion.Play();
        }

        if(other == portal){
            Points.pointVal += 1;
            success.Play();
            portal.transform.position = new Vector3(Random.Range(-33.0f, 36.0f), -4.0f, Random.Range(-87.0f, 83.0f));
        }
    }
}
