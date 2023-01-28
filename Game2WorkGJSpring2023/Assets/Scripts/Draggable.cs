using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

    Vector3 mousePositionOffset;

    private Vector3 getMouseWorldPosition(){
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void onMouseDown(){
        mousePositionOffset = gameObject.transform.position - getMouseWorldPosition();
    }   

    private void onMouseDrag(){
        transform.position = getMouseWorldPosition() + mousePositionOffset;
    }
}