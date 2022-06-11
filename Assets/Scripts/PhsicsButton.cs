using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhsicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    public UnityEvent onPressed, onReleased;

    private bool _isPressed;
    private int pressCount;
    private int releaseCount;
    private Vector3 _startPos;
    private float start_y;
    private ConfigurableJoint _joint;
    // Start is called before the first frame update
    void Start()
    {
        pressCount = 0;
        _startPos = transform.localPosition;
        start_y = _startPos.y;
        _joint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
        {
            // Debug.Log("startPos.y와 start_y" + _startPos.y + " " + start_y);
            Pressed();
            pressCount += 1;
        }
        if (_isPressed && GetValue() - threshold <= 1)
        {
            Released();
        }

    }
    private float GetValue()
    {
        var value = Vector3.Distance(_startPos,transform.localPosition) / _joint.linearLimit.limit;

        if (Mathf.Abs(value) < deadZone)
            value = 0;

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        if(_isPressed == false)
        {
            _isPressed = true;
            onPressed.Invoke();
            // Debug.Log("pressed" +_startPos.y + start_y + "_startPos.y and start_y" );
            // Debug.Log("Pressed" + (int)(GetValue() + threshold));
        }
    }
    private void Released()
    {
        if(_isPressed == true)
        {
            _isPressed = false;
            onReleased.Invoke();
            // Debug.Log("released" + _startPos.y + start_y + "_startPos.y and start_y" );
            // Debug.Log("Released" + (int)(GetValue() + threshold));
        }
    }
}