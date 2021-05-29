using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento1 : MonoBehaviour
{

    public float velX = 2f;
    public float velY = 200f;
    public Rigidbody2D bola;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            bola.AddForce(new Vector2(0, 35f), ForceMode2D.Impulse);
           
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-velX, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(velX, 0, 0));
        }

    }
}
