using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private int candyCount = 0;

	// Use this for initialization
	void Start () {
        candyCount = 0;
	}
	
    public void Found_Candy()
    {
        candyCount++;
    }

}
