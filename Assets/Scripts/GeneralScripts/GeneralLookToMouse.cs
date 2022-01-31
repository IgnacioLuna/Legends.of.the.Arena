using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GeneralLookToMouse : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    protected PhotonView view;
    private Vector3 pointToLook;
    private Plane groundPlane;
    private Ray cameraRay;
    private float rayLenght;

    protected void Start()
    {
        mainCamera = GameObject.Find("Camera");
        view = GetComponent<PhotonView>();
    }

    protected void Update()
    {
        if (view.IsMine)
            LookAtMouse();
    }

    private void LookAtMouse()
    {
        cameraRay = mainCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
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
