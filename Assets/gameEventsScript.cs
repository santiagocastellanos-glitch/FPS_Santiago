using System;
using UnityEngine;

public class gameEventsScript : MonoBehaviour
{
    public static gameEventsScript instance;

    public event Action onDoorTriggerEnter;
    private void Awake()
    {
        if(instance == null)
        {
            instance = null;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OpenTriggerDoor()
    {
        onDoorTriggerEnter();
    }
}
