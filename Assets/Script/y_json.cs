using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class charadate{
	public string prefecture_name;
	public int prefecture_num;
	public int chara_num;
}

[Serializable]
public class Serialization<T>
{
	[SerializeField]
	T[] savedata;
	public T[] ToList() { return savedata; }

	public Serialization(T[] target)
	{
		this.savedata = target;
	}
}

public class y_json : MonoBehaviour {
	[SerializeField]
	charadate[] hara = new charadate[5];

	// Use this for initialization
	void Start () {
		charadate chara;

		for (int i = 0; i < 5; i++) {
			chara=new charadate();
			chara.prefecture_name="アメリカ";
			chara.prefecture_num = 0;
			chara.chara_num = 2;
			hara [i] = chara;
		}

		string json = JsonUtility.ToJson (new Serialization<charadate>(hara));
		Debug.Log (json);

		Debug.Log (Screen.width);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
