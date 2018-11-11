using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class y_loadtest : MonoBehaviour {
	public Text txt;

	// Use this for initialization
	void Start () {
		txt.text += Application.streamingAssetsPath + "\n";
		txt.text += "jar:file://" + Application.dataPath + "!/assets" + "\n";
		string[] files = Directory.GetFiles ("jar:file://" + Application.dataPath + "!/assets/data","*.png",SearchOption.AllDirectories);
		foreach(string test in files){
			txt.text += test + "\n";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
