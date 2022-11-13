using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionOnSelectExit : MonoBehaviour
{
    Vector3 StartValuesPosition;
    Quaternion StartValuesRotation;

    void Start()
    {
        StartValuesPosition = transform.position;
        StartValuesRotation = transform.rotation;
    }

    public void ResetPositionOnExit()
    {
        transform.position = StartValuesPosition;
        transform.rotation = StartValuesRotation;
    }
}
