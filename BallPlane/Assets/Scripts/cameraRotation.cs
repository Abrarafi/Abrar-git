using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    public float turnspeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Mouse X");
        float yMovement = Input.GetAxis("Mouse Y");
        if(xMovement!=0)
        {
            this.transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * xMovement);
        }
    }
}
