using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        transform.position = new Vector3(pos[0], pos[1], pos[2] - 7);
        //transform.position = transform.position + new Vector3(0, 10, 0);

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 KamaraPos = transform.position;
        
        float eulerAngX = transform.localEulerAngles.x;
        float eulerAngY = transform.localEulerAngles.y;
        float eulerAngZ = transform.localEulerAngles.z;

        transform.position = new Vector3(pos[0] - KamaraPos[0], pos[1] - KamaraPos[1], pos[2] - KamaraPos[2] - 7);


        if (Input.GetAxis("Mouse X") < 0)
        {
            //Code for action on mouse moving left
            transform.RotateAround(Sphere.transform.position, Vector3.up, 1);
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            //Code for action on mouse moving right
            transform.RotateAround(Sphere.transform.position, Vector3.up, -1);
        }

        if (Input.GetAxis("Mouse Y") < 0)
        {
            //Code for action on mouse moving left
            transform.RotateAround(Sphere.transform.position, Vector3.up, 1);
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            //Code for action on mouse moving right
            transform.RotateAround(Sphere.transform.position, Vector3.up, -1);
        }

    }

    void Rotate()
    {
        
    }
}
