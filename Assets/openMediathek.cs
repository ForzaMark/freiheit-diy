using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMediathek : MonoBehaviour
{
    public void OnGrab()
    {
        Application.Quit();
        Application.OpenURL("https://www.zdf.de/show/dalli-dalli/folge1-112.html");
    }
}
