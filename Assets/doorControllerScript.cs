using UnityEngine;
using DG.Tweening;

public class doorControllerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameEventsScript.instance.onDoorTriggerEnter += OpenDoor;
    }

    private void OnDisable()
    {
        gameEventsScript.instance.onDoorTriggerEnter -= OpenDoor;
    }

    private void OnDestroy()
    {
        gameEventsScript.instance.onDoorTriggerEnter -= OpenDoor;
    }

    // Update is called once per frame
    void OpenDoor()
    {
        //transform.Translate(new Vector3(4.734f,3,0.88437f));
        transform.DOMoveY(3, 2);
    }
}
