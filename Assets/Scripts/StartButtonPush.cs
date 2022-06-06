using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonPush : MonoBehaviour
{
    public static bool b_start = false;

    Button m_Button;


    // Use this for initialization
    void Start()
    {
        m_Button = GetComponent<Button>();
        //Debug.Log(m_Button);
    }

    public void clickButton()
    {
        b_start = !b_start;
        bool _b = StartToggleCheck.b_assist;
        if (_b) 
        {
            Debug.Log("assist mode\n");
        }
        else
        {
            Debug.Log("performing mode\n");
        }
    }

    //public void moveCamera(bool _b)
    //{
        
    //    if (!_b)
    //    {
    //        transform.position = new Vector3(-3.6f, 2.91f, -2.44f);
    //        transform.LookAt(new Vector3(-6.7f,5f,-0.7f));
    //    }
    //    else
    //    {

    //    }
    //}
}
