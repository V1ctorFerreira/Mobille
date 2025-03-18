using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TouchScreen : MonoBehaviour
{
  public UnityEvent OnTouch;
    Vector2 inicialPos;

  
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
      //  {
          //  OnTouch.Invoke();
      //  }
        if (Input.GetButtonDown("Fire1"))
        {
            inicialPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Vector2 finalPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(finalPos.x < inicialPos.x)
            {

                print("Esquerda");
            }
            if(finalPos.x > inicialPos.x)
            {
                print("Direita");
            }
        }
    }
}
