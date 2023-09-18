using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float zindex;
    float xindex;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
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
    void OnMouseDown() // Mouse Klickt on the Objekt
    {   
        
        
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 ScreenPos=cam.WorldToScreenPoint(pos);
        float newPositionx = Input.mousePosition.x;
		float newPositiony = Input.mousePosition.y;

        rb.AddForce(ScreenPos[0]-newPositionx,200,0);
    }

}
