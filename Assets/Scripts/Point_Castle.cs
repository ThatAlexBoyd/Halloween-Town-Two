using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Point_Castle : Point {

    public GameObject door_left;
    public GameObject door_right;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Found_Key();
        }
    }

    public override void Init()
    {
        base.Init();
    }

    //key has been found
    public void Found_Key()
    {
        PlayFinishedAudio();
        OnFinished();

        //spot specific
        OpenDoor();
    }

    private void OpenDoor()
    {
        door_left.transform.DORotate(new Vector3(0, -60, 0), 1f, RotateMode.LocalAxisAdd);
        door_right.transform.DORotate(new Vector3(0, 60, 0), 1f, RotateMode.LocalAxisAdd);
    }

}
