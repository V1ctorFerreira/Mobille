using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TouchScreen : MonoBehaviour
{
  public UnityEvent OnTouch;
   

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnTouch.Invoke();
        } 
    }
}
