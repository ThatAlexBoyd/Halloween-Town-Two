using UnityEngine;
using System.Collections;

public class Point_Grave : Point {

    bool found_milk = false;
    bool found_waffle = false;
    bool found_burger = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            FoundMilk();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            FoundBurger();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            FoundWaffle();
        }
    }


    public void FoundMilk()
    {
        //milk audio
        found_milk = true;
        FoundCheck();
    }

    public void FoundBurger()
    {
        //burger audio
        found_burger = true;
        FoundCheck();
    }

    public void FoundWaffle()
    {
        //waffle audio
        found_waffle = true;
        FoundCheck();
    }

    public void FoundCheck()
    {
        if(found_burger && found_milk && found_waffle)
        {
            PlayFinishedAudio();
            OnFinished();

            //spot specfic
        }
    }
}
