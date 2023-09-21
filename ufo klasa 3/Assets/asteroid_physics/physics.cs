using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed;
    public float left;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movevertical = Input.GetAxis("vertical");
        
    }
}
