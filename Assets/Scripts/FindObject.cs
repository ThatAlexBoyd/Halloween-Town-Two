using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using DG.Tweening;

public class FindObject : MonoBehaviour
{

    public UnityEvent clickEvent;
    private float speed = 1;

    /// <summary>
    /// make sure tag is set to make is findable and turnn off collider
    /// </summary>
    void Awake()
    {
        gameObject.tag = "object";
        GetComponent<Collider>().enabled = false;
    }

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, speed, 0));
    }

    /// <summary>
    /// this will replace witht he fire event from gaze
    /// </summary>
    public void OnMouseDown()
    {
        clickEvent.Invoke();
        Cleanup();
    }

    /// <summary>
    /// Turn on colliders
    /// </summary>
    public void Init()
    {
        GetComponent<Collider>().enabled = true;
    }

    private void Cleanup()
    {
        speed = 10;
        gameObject.GetComponent<Renderer>().material.DOFade(0, 3);
        GetComponent<Collider>().enabled = false;
    }

}
