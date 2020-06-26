using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode fowardKey;
    public KeyCode shootKey;
    public KeyCode backKey;
    public KeyCode downKey;
    public GameObject Projektil;
    public Rigidbody z;
    public Quaternion Quat;
    public Vector3 w;
    public Vector3 x;
    public Vector3 y;
    public Vector3 p;
    public Transform Pos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Jump taste wurde gedrückt");
            z.AddForce(x);
        }

        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("Down taste wurde gedrückt");
            z.AddForce(-x);

        }
        if (Input.GetKeyDown(fowardKey))
        {
            Debug.Log("Forwärts taste wurde gedrückt");
            z.AddForce(y);

        }

        if (Input.GetKeyDown(backKey))
        {
            Debug.Log("Back taste wurde gedrückt");
            z.AddForce(-y);

        }

        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("Schiessen wenn taste gedrückt wurde");
           GameObject Proj = Instantiate(Projektil, Pos.position, Quat);
            Rigidbody rbp = Proj.GetComponent(typeof(Rigidbody)) as Rigidbody;
            rbp.AddForce(p);
            
        }


    }
}