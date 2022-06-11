using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public static float pressedCount = 0.0f;    //다른 스크립트에서 ButtonVR.pressedCount로 접근가능.
    GameObject presser;
    AudioSource sound;
    bool isPressed;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pressed");
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(-11.459f, 2.317f + 0.003f, 17.757f);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Released");
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(-11.459f, 2.317f + 0.015f, 17.757f);
            onRelease.Invoke();
            isPressed = false;
            ToCountPressed();
        }
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(-2.58f, 1.9804f, 2.3f);
        sphere.AddComponent<Rigidbody>();
    }

    //환자에 압박이 가해졌을때 그 횟수를 카운트하기 위한 함수.
    public float ToCountPressed(){
        pressedCount += 1.0f;
        if(Patient.minVital <= 65){
            Patient.minVital += 1.0f;
            Patient.maxVital += 0.9f;
        }
        
        Debug.Log(pressedCount + "심장에 압박이 가해지고있습니다.");
        return pressedCount;
    }

}
