using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstscript : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float zindex;
    float xindex;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Keybutton pressed
        {
            rb.AddForce(Vector3.up * 500);
        }
        xindex = Input.GetAxis("Horizontal");
        zindex = Input.GetAxis("Vertical");

        rb.AddForce(xindex * speed, 0, zindex * speed);

    }
    private void OnMouseDown() // Mouse Klickt on the Objekt
    {
        rb.AddForce(Vector3.up * 500);
    }

}