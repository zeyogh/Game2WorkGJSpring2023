using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{

    public Texture2D cursor;

    public Texture2D cursor2;
    

    

    private void Awake(){
        
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
    }

    

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
             ChangeCursor(cursor2);
             Cursor.lockState = CursorLockMode.Confined;
        }

        if(Input.GetKeyUp(KeyCode.Mouse0)){
            ChangeCursor(cursor);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    private void ChangeCursor(Texture2D cursorType){
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

    

   
}
