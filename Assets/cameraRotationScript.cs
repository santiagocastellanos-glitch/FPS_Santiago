
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraRotationScript : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private float xRotation = 0;

    [SerializeField]
    private float xSensitivity = 100;

    [SerializeField]
    private float ySensitivity = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current == null) return;
        
        Vector2 mouseInput = Mouse.current.delta.ReadValue();
        xRotation -= mouseInput.y * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80, 80);

        transform.Rotate(0f, mouseInput.x * xSensitivity, 0);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);


    }
}
