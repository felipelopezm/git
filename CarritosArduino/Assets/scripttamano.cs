using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.IO.Ports; //Library to read our ardunio data
using System.Collections;//to use Ienumarator in our code

public class scripttamano : MonoBehaviour
{
    SerialPort seri = new SerialPort("COM3", 9600);//define our port
    // Use this for initialization
    void Start()
    {

        seri.Open(); // iba en el otro

        seri.ReadTimeout = 1;



    }

    // Update is called once per frame
    void Update() {
    if (seri.IsOpen) // iba en el otro
            {
                try
                {


                    if (seri.ReadByte() == 1)
                    {
                        transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
}
                    else if (seri.ReadByte() == 2)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
transform.localScale = new Vector3(5.25f, 5.25f, 5.25f);
                    }
                    else if (seri.ReadByte() == 3)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
transform.localScale = new Vector3(10.5f, 10.5f, 10.5f);
                    }
                }
                catch (System.Exception) { }
            }

    }
}