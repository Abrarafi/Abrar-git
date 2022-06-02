using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject ball1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xVal = Input.GetAxis("Horizontal");
        print(xVal);
        float yVal = Input.GetAxis("Vertical");
        if(xVal!=0)
        {
            ball1.transform.Translate(Vector3.forward * Time.deltaTime * xVal);

        }
        if (yVal != 0)
        {
            ball1.transform.Translate(Vector3.right * Time.deltaTime * yVal);

        }
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            ball1.transform.Translate(Vector3.forward * Time.deltaTime);
        }*/
    }
}
