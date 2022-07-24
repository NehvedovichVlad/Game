using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private  float _speedPerson = 1;
    private float _rotationSpeed = 300;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 offset = new Vector3(h, 0, v) * _speedPerson * Time.deltaTime;
        transform.Translate(offset);

        float yRotation = Input.GetAxis("Mouse X");
        Debug.Log(yRotation);
        transform.Rotate(0, yRotation * _rotationSpeed * Time.deltaTime, 0);

        if(Input.GetKey(KeyCode.Space))
        {    
            _speedPerson = 3;
        }
        else
        {
            _speedPerson = 1;
        }
    }
}
 