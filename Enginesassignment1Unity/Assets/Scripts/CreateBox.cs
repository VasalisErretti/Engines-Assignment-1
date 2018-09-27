using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{

	public Transform SpawnPoint;
	public Rigidbody Prefab;

	// Use this for initialization
	void OnTriggerEnter () {

		Rigidbody RigidPrefab;
		RigidPrefab = Instantiate (Prefab, SpawnPoint.position, SpawnPoint.rotation)as Rigidbody;
	}
}