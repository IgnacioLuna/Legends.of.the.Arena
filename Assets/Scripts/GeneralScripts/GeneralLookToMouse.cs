using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralLookToMouse : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Plane groundPlane;
    private float rayLenght;
    
    void Update()
    {
        LookAtMouse();
    }

    private void LookAtMouse()
    {
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        groundPlane = new Plane(Vector3.up, Vector3.zero);

        if (groundPlane.Raycast(cameraRay, out rayLenght))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLenght);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }
}
