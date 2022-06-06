using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
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
        }
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(-2.58f, 1.9804f, 2.3f);
        sphere.AddComponent<Rigidbody>();
    }

}
