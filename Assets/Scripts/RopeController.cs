using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    private Transform _transform;
    private Camera _camera;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenMousePosition = Input.mousePosition;
        Vector3 mousePosition = _camera.ScreenToWorldPoint(screenMousePosition);

        _transform.position = new Vector3(mousePosition.x, _transform.position.y, _transform.position.z);
    }
}
