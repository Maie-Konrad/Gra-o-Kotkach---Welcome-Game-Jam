using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseDetector : MonoBehaviour
{
    private bool isHovered;
    [SerializeField] private Camera targetCamera;
    [SerializeField] private GameObject cube; 
    void Update()
    {
        if (Mouse.current == null) return;

        Vector2 mousePosition = Mouse.current.position.ReadValue();

        Ray ray = targetCamera.ScreenPointToRay(mousePosition);

        //cube.transform.position = ray.origin;

        if (Physics.Raycast(ray, out RaycastHit hit) &&
            hit.collider.gameObject == gameObject)
        {
            Debug.Log("1"); // Myszka nad obiektem

            if (Mouse.current.leftButton.wasPressedThisFrame)
                Debug.Log("2"); // Kliknięto obiekt
        }
    }
}

