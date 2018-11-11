using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AudioManager.Instance.PlayBGM(GameData.BGM_NAME_TITLE);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
