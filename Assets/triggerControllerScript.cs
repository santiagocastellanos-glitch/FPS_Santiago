using UnityEngine;

public class triggerControllerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameEventsScript.instance.OpenTriggerDoor();
    }
}
