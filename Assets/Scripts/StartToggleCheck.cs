using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartToggleCheck : MonoBehaviour
{
    Toggle m_Toggle;

    // Use this for initialization
    void Start()
    {
        m_Toggle = GetComponent<Toggle>();
        Debug.Log(m_Toggle);

    }

    public void clickToggle()
    {
        if (m_Toggle.isOn)
        {
            Debug.Log("Toggle Click!\n");
        }
        else
        {
            Debug.Log("Toggle not Clicked!\n");
        }
    }
}
