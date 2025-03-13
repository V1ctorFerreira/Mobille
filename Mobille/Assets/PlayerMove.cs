using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Vector2 jumpFoce;
    // Start is called before the first frame update
    void Start()
    {
       rb =GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
       
    }
  public   void Jump()
    {
       rb.AddForce(jumpFoce);
    }
}
