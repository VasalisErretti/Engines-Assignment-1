using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{

	public Transform SpawnPoint;
	public Rigidbody Prefab;

    // Use this for initialization
    void Start()
    {

        GameObject prefab = Resources.Load("Cube") as GameObject;
        for (int i = 0; i < 1000; i++)
        {
            GameObject go = Instantiate(prefab) as GameObject;
            go.transform.position = new Vector3(0, i * 5, 20);
        }

    }
}