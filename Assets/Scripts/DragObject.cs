using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class DragObject : MonoBehaviour

{

    private Vector3 mOffset;

    public LayerMask layerMask;



    void OnMouseDown()

    {
        mOffset = gameObject.transform.position - GetTouchAsWorldPoint();
    }



    private Vector3 GetTouchAsWorldPoint()

    {

        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 30.0f, layerMask);
        Vector3 touchPoint = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        return touchPoint;

        // Pixel coordinates of mouse (x,y)
        //Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen

        //mousePoint.z = mZCoord;



        // Convert it to world points

        //return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetTouchAsWorldPoint() + mOffset;

    }

    



}