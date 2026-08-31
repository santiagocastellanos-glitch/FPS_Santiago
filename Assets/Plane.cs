using UnityEngine;
using DG.Tweening;

public class Plane : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DOMoveX(100, 20).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
