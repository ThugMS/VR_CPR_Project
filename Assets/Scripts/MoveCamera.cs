using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }


    public void transformCam()
    {
        bool _b = StartToggleCheck.b_assist;
        Debug.Log(_b);
        if (!_b)
        {
            transform.position = new Vector3(-2.501f, 4.317f, -2.769f);
            transform.LookAt(new Vector3(-6.7f, 3f, 3f));
        }
        else
        {
            transform.position = new Vector3(-120f, 3.586f, -3.677f);
            transform.LookAt(new Vector3(1.79f, -7f, 2300f));
        }
    }
}
