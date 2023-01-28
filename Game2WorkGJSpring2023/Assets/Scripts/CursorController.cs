using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{

    public Texture2D cursor;
    

    

    private void Awake(){
        
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void ChangeCursor(Texture2D cursorType){
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

    

   
}
