using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralLookToMouse : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Vector3 pointToLook;
    private Plane groundPlane;
    private Ray cameraRay;
    private float rayLenght;
    
    void Update()
    {
        LookAtMouse();
    }

    private void LookAtMouse()
    {
        cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        groundPlane = new Plane(Vector3.up, Vector3.zero);
        if (groundPlane.Raycast(cameraRay, out rayLenght))
        {
            pointToLook = cameraRay.GetPoint(rayLenght);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }

    public Vector3 GetPointToLook()
    {
        return pointToLook;
    }
}
