using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    bool flag119 = false;
    bool flagAED = false;
    public void On119ButtonClick()
    {
        Debug.Log("119button pressed");
        flag119 = true;
        GameObject.Find("CameraCanvas1").transform.Find("119HelpButton").gameObject.SetActive(false);
        GameObject.Find("CameraCanvas2").transform.Find("119HelpButton").gameObject.SetActive(false);
        if(flag119 && flagAED){
            GameObject.Find("CameraCanvas1").SetActive(false);
            GameObject.Find("CameraCanvas2").SetActive(false);
            GameObject.Find("ScreenCanvas").transform.Find("HelpText").gameObject.SetActive(false);
            GameObject.Find("ScreenPanel").transform.Find("NumPerMin").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("NumPerCycle").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("ExplainText").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("VRpic1").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("VRpic2").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("VitalText").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("CPRText").gameObject.SetActive(true);
        }
    }

    public void OnAEDButtonClick(){
        Debug.Log("AEDbutton pressed");
        flagAED = true;
        GameObject.Find("CameraCanvas1").transform.Find("AEDHelpButton").gameObject.SetActive(false);
        GameObject.Find("CameraCanvas2").transform.Find("AEDHelpButton").gameObject.SetActive(false);
        if(flag119 && flagAED){
            GameObject.Find("CameraCanvas1").SetActive(false);
            GameObject.Find("CameraCanvas2").SetActive(false);
            GameObject.Find("ScreenCanvas").transform.Find("HelpText").gameObject.SetActive(false);
            GameObject.Find("ScreenPanel").transform.Find("NumPerMin").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("NumPerCycle").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("ExplainText").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("VRpic1").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("VRpic2").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("VitalText").gameObject.SetActive(true);
            GameObject.Find("ScreenPanel").transform.Find("CPRText").gameObject.SetActive(true);
        }
    }
}
