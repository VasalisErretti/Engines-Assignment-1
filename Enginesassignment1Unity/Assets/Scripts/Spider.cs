using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public float maxspeed = 10;
    public float minspeed = 0;
    float speed;
	
	void Start ()
    {
        speed = Random.Range(minspeed, maxspeed);
	}
	
	
	void Update ()
    {
		float forward = Input.GetAxis ("Vertical") * speed;
		float strafe = Input.GetAxis ("Horizontal") * speed;
            transform.Translate(strafe * Time.deltaTime * speed, 0f, forward * Time.deltaTime * speed);
	}
}
