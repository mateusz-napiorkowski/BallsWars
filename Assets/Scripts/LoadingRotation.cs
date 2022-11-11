using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingRotation : MonoBehaviour
{
    public RectTransform _icon;
    public float _timeStep;
    public float _angleStep;

    float _startTime;

    // Start is called before the first frame update
    void Start()
    {
        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - _startTime >= _timeStep)
        {
            Vector3 iconAngle = _icon.localEulerAngles;
            iconAngle.z += _angleStep;
            _icon.localEulerAngles = iconAngle;
            _startTime = Time.time;
        }
    }
}
