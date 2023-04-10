using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelDisplay : MonoBehaviour {

    public Text Level;

    public static int levelNumber = 1;

	// Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Level.text = "Level " + levelNumber;
    }
}
