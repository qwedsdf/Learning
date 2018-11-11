using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceanManager : SingletonMonoBehaviour<ChangeSceanManager>
{
    public GameObject feed_img;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeScean(string NextSceneName,string NextBgmName)
    {
        StartCoroutine(LoadScene(NextSceneName, NextBgmName));
    }

    IEnumerator LoadScene(string NextSceneName, string NextBgmName)
    {
        float alpha = 255f;
        while (alpha < 0)
        {
            alpha--;
            feed_img.GetComponent<Image>().color= new Color(255f, 255f, 255f, alpha);
            //if (alpha < 0)
            //{
            //    SceneManager.LoadScene(NextBgmName);
            //    break;
            //}
            yield return null;
        }

        if(SceneManager.GetActiveScene().name != NextSceneName)
        {

        }
    }
}
