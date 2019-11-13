using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSoundScript : MonoBehaviour
{
    public static BGSoundScript instance = null;
    public static BGSoundScript Instance
    {
        get { return instance; }
    }

    // Update is called once per frame
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
                return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
