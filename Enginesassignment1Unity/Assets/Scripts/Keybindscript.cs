﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keybindscript : MonoBehaviour {

    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
    private GameObject currentKey;
    private Color32 normal = new Color32(39,171,249,255);
    private Color32 selected = new Color(239,116,36,255);
    public Text up, down, left, right;
	// Use this for initialization
	void Start () {
        keys.Add("Up",(KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up", "W")));
        keys.Add("Down", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down", "S")));
        keys.Add("Left", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A")));
        keys.Add("Right", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "D")));

        up.text = keys["Up"].ToString();
        down.text = keys["Down"].ToString();
        left.text = keys["Left"].ToString();
        right.text = keys["Right"].ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(keys["Up"]))
        {
            //Do a move action add this in

        }
        if (Input.GetKeyDown(keys["Down"]))
        {
            //Do a move action add this in

        }
        if (Input.GetKeyDown(keys["Left"]))
        {
            //Do a move action add this in

        }
        if (Input.GetKeyDown(keys["Right"]))
        {
            //Do a move action add this in

        }
    }

    void OnGUI()
    {
        if(currentKey != null)
        {
            Event e = Event.current;
            if(e.isKey)
            {
                keys[currentKey.name]= e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                currentKey.GetComponent<Image>().color = normal;
                currentKey = null;
            }
        }
    }
    public void ChangeKey(GameObject clicked)
    {
      if(currentKey != null)
      {
            currentKey.GetComponent<Image>().color = normal;
      }

      currentKey = clicked;
      currentKey.GetComponent<Image>().color = selected;
    }
    public void SaveKeys()
    {
        foreach(var key in keys)
        {
            PlayerPrefs.SetString(key.Key,key.Value.ToString());
        }

        PlayerPrefs.Save();
    }
}
