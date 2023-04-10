using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame: MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y <= -1) {
            GameObject.Destroy(GameObject.Find("WhisperSource"));
            SceneManager.LoadScene("GameOver");       
        }
    }
}
