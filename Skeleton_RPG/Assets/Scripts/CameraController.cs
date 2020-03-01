using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// source code in EP1
public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;
    public float pitch = 2f;
    public float currentZoom = 10f;
    //camera rotation variables 
    private float currentYaw = 0f;
    public float yawSpeed = 100f;
    



private void Update() 
{
    currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
    currentZoom  = Mathf.Clamp(currentZoom, minZoom, maxZoom);
    currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;

    
}
    void LateUpdate() 
    {
        transform.position = target.position - offset * currentZoom ;
        transform.LookAt(target.position + Vector3.up * pitch);
        transform.RotateAround(target.position, Vector3.up, currentYaw);
        
    }
}
