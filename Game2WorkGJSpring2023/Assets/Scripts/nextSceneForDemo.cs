using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextSceneForDemo : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision){

        Debug.Log("should change Scene");
         if(collision.gameObject.CompareTag("nextScene"))
        {
            
            SceneManager.LoadScene("PlayerMovementDemo");
            
        }
    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("PlayerMovementDemo");
    }
}
