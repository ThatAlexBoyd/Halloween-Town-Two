using UnityEngine;
using System.Collections;

public class ObjectController : MonoBehaviour {

    public FindObject[] objects_castle;
    public FindObject[] objects_grave;

    public void Enable_Castle()
    {
        for (int i = 0; i < objects_castle.Length; i++)
        {

            objects_castle[i].Init();
        }
    }

    public void Enable_Grave()
    {
        for (int i = 0; i < objects_grave.Length; i++)
        {
            objects_grave[i].Init();
        }
    }

}
