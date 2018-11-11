using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
    Dictionary<string, AudioClip> bgm_dic, se_dic;
    public AudioSource Audio_Bgm, Audio_Se;
    string name_NextSE,name_NextBGM;

    private void Awake()
    {
        LoadMusicAll();
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// BGM,SEを全てロード
    /// </summary>
    void LoadMusicAll()
    {
        if (this != Instance)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);

        bgm_dic = new Dictionary<string, AudioClip>();
        se_dic = new Dictionary<string, AudioClip>();

        Object[] Bgm_List = Resources.LoadAll("Audio/BGM");
        Object[] Se_List = Resources.LoadAll("Audio/SE");

        foreach (AudioClip bgm in Bgm_List)
        {
            bgm_dic[bgm.name] = bgm;
        }

        foreach (AudioClip se in Se_List)
        {
            se_dic[se.name] = se;
        }
    }

    /// <summary>
    /// SEを流す
    /// </summary>
    /// <param name="SEname">SEの名前</param>
    /// <param name="delay">流し始めるまでの間</param>
    public void PlaySE(string SEname,float delay = 0)
    {
        if (!se_dic.ContainsKey(SEname))
        {
            return;
        }
        name_NextSE = SEname;
        Invoke("DelayPlaySE",delay);
    }

    void DelayPlaySE()
    {
        Audio_Se.PlayOneShot(se_dic[name_NextSE] as AudioClip);
    }

    /// <summary>
    /// BGMを流す
    /// </summary>
    /// <param name="BGMname">流したいBGMの名前</param>
    /// <param name="delay">間</param>
    public void PlayBGM(string BGMname, float delay = 0)
    {
        if (!bgm_dic.ContainsKey(BGMname))
        {
            Debug.Log("ないで");
            return;
        }
        name_NextBGM = BGMname;
        Debug.Log(bgm_dic[BGMname].name);
        Invoke("DelayPlayBGM", delay);
    }

    void DelayPlayBGM()
    {
        Audio_Bgm.PlayOneShot(bgm_dic[name_NextBGM]);
    }
}
