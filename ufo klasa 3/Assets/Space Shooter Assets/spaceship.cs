using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship : MonoBehaviour
{
    public float speed;
    Rigidbody2D  rb2d;
    // Start is called before the first frame update
    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
       Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce(movement*speed);
        if (Input.GetKey(KeyCode.W))
            {
            transform.position += new Vector3(0, 2 * Time.deltaTime, 0);
                };
        if (Input.GetKey(KeyCode.S))
            {
            transform.position += new Vector3(0, -2 * Time.deltaTime, 0);
                };
        if (Input.GetKey(KeyCode.D))
            {
              transform.position += new Vector3 (1, 0 / Time.deltaTime );
        }
        if (Input.GetKey(KeyCode.A))
             {
             transform.position += new Vector3 (-1, 0 / Time.deltaTime);
        }


    }
}
