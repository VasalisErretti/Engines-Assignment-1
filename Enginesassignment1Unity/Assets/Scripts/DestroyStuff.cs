using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStuff : MonoBehaviour {
   

    void OnCollisionEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
