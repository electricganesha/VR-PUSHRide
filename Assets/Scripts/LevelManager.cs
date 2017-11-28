using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    bool hasEndBeenReached = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(hasEndBeenReached)
        {
            if (Input.GetButtonUp("Tap"))
            {
                SceneManager.LoadScene(0);
            }
        }

	}

    public void EndHasBeenReached()
    {
        hasEndBeenReached = true;
    }
}
