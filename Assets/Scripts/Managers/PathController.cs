using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PathController : MonoBehaviour {

    public DOTweenPath playerPath;
    public ObjectController objCont;

	void Update ()
    {
        playerPath.tween.OnWaypointChange(CheckPoint);
    }

    /// <summary>
    /// Points are unfortunately hard coded - beware
    /// </summary>
    /// <param name="index"></param>
    public void CheckPoint(int index)
    {
        switch(index)
        {
            case 5: //outside castle wall
                playerPath.tween.Pause();
                objCont.Enable_Castle();
                break;
            case 12: //gate before going into cemetery
                playerPath.tween.Pause();
                objCont.Enable_Grave();
                break;
            case 14: //at skelton king
                playerPath.tween.Pause();
                break;
            default:
                Debug.Log("Not Used Point: " + index);
                break;
        } 

    }
    
    public void ResumeTween()
    {
        playerPath.tween.Play();
    }
}
