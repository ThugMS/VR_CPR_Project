using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patient : MonoBehaviour
{
    public int flag = 0;
    public float speed = 1.0f;
    public GameObject patient, startText, helpText;  
    public float patientVital = 0.0f;
    public float minVital = 80.0f;   //환자의 최소 바이탈
    public float maxVital = 90.0f;  //환자의 최대 바이탈
    public int count = 0;
    public int shoulderCount = 0;
    public float weight = 1.0f; //환자의 vital에 가중치 값.
    public Text patientVitalText; // 환자의 vital을 표시할 text

    //환자의 바이탈을 표시해주는 변수
    void Start()
    {
        //vitalOfPatient();
        patient = GameObject.Find("Patient");   //Patient1 게임내의 오브젝트를 연결해주는 코드.
        startText = GameObject.Find("StartText");
        helpText = GameObject.Find("ScreenCanvas");
        patientVitalText.text = "심박수 : " + patientVital;
    }

    // Update is called once per frame 1초에 60번 불린다.
    void Update()
    {
        
        count++;
        if (count % 240 == 0){
            vitalOfPatient();
            patientVitalText.text = "심박수 : " + patientVital;
            
            count = 0;
        }
        // if(flag == 0){
        //     patient.GetComponent<Transform>().Translate(Vector3.forward * speed * Time.deltaTime);
        // }
        // else{
        //     patient.GetComponent<Transform>().Translate(Vector3.back * speed * Time.deltaTime);
        //     Debug.Log("충돌시 뒤로 이동.");
        // }
    }

    void vitalOfPatient(){
        patientVital = UnityEngine.Random.Range((int)minVital*weight, (int)maxVital*weight);
        // Debug.Log((int)patientVital); 
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Cube"){   //Tag는 유니티내부의 Inspector 바로 밑에 있음. 직접 Tag를 설정해줘야함.
            Debug.Log("환자와 충돌이 감지되었습니다.");
            shoulderCount++;
            if(shoulderCount>=1){
                Debug.Log("ShoulderCount" + shoulderCount + startText);
                startText.SetActive(false);
                helpText.transform.Find("HelpText").gameObject.SetActive(true);
            }
            else{
                startText.SetActive(true);
                helpText.SetActive(false);
            }
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Cube"){
            Debug.Log("환자와 계속 충돌중입니다.");
            helpText.SetActive(true);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if(collision.collider.tag == "Cube"){
            Debug.Log("환자와의 충돌이 종료되었습니다.");
        }
        
    }

}