using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initialize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [RuntimeInitializeOnLoadMethod()]
    static void LoadManagerScean()
    {
        SceneManager.LoadSceneAsync("00_Manager", UnityEngine.SceneManagement.LoadSceneMode.Additive);
    }
}
