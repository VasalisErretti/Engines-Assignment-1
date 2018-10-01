using System.Collections;
using System.Collections.Generic;
using myDLL;
using UnityEngine;

public class itemDrop : MonoBehaviour {


    public ItemDrop getItem = new ItemDrop();
    public int n;
    public int m;

    // Use this for initialization
    void Start() {
        n = Random.Range(0, 10);
        m = Random.Range(0, 10);

        getItem.ItemSuccess(n, m);

        if (getItem.chance == true)
        {
            Debug.Log("YOU FOUDN AN ITEM");
        }
        else
        {
            Debug.Log("No Item Found");
        }
	}

	

}
