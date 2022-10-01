using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabFunkamateurExited : MonoBehaviour
{
    public void OnGrabExited()
    {
        // These are world space coordinates. The coordinates on the magazine are given related to the room
        transform.position = new Vector3(-10.6f, 3.5f, 14.8f);
        transform.eulerAngles = new Vector3(0, 253.9f, 0);
    }
}
