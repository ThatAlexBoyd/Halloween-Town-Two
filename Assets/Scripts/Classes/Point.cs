using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

    public string id;
    public AudioSource audioCue;
    public PathController pc;

    public virtual void Init()
    {
        Debug.Log("@"+id);
    }

    public virtual void OnFinished()
    {
        pc.ResumeTween();
    }

    public void PlayFinishedAudio()
    {
        if (audioCue != null)
        {
            audioCue.Play(); 
        }
    }

}
