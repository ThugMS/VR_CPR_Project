using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartToggleCheck : MonoBehaviour
{
    Toggle m_Toggle;

    public static bool b_assist = false;

    // Use this for initialization
    void Start()
    {
        m_Toggle = GetComponent<Toggle>();
        Debug.Log(m_Toggle);

    }

    public void clickToggle()
    {
        b_assist = !b_assist;
        if (m_Toggle.isOn)
        {
            Debug.Log("Toggle Click!\n");
            //Debug.Log(b_assist);
        }
        else
        {
            Debug.Log("Toggle not Clicked!\n");
            //Debug.Log(b_assist);
        }
    }
}
