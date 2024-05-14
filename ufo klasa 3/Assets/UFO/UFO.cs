using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UFO : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2d;
    public float rotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizont = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movements = new Vector2(moveHorizont, moveVertical);
        rb2d.AddForce(movements*speed);
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D obiekt)
    {
        if(obiekt.gameObject.CompareTag("PickUp"))
        {
            Destroy(obiekt.gameObject);
        }
    }
}

