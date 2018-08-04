using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Vector2[] myPositions;
    public int counter = 0;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            counter = counter - 1;
            //if counter < 0
            //then counter = number in range of the array
            
            // transform.position = myposition[counter];
        }




        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            counter = counter + 1;
            //if counter > 2
            //then counter = number in range of the array

            // transform.position = myposition[counter];

        }
    }

}
