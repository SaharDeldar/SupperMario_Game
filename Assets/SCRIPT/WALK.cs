using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WALK : MonoBehaviour
{
     public float speed = 50;
     public float force = 300;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce( Vector2.up * force );
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
   

    }

}
