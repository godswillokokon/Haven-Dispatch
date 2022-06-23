using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour

{

    void OnCollisionEnter2D(Collision2D other) 
    {
      UnityEngine.Debug.Log("Bump!");
      
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        UnityEngine.Debug.Log("What was that?");
    }
}
