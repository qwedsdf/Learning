using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class y_aseetbundle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [MenuItem("Assets/Build Asset Bundles")]
    static void BuildABs()
    {
        BuildPipeline.BuildAssetBundles(
            "Assets/AssetBundles/Android",
            BuildAssetBundleOptions.None,
            BuildTarget.Android
        );
        AssetDatabase.Refresh();
    }
}
