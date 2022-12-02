using UnityEngine;

public class OnTvRemoteGrabbed : MonoBehaviour
{
    public void remoteGrabbed()
    {
        Application.Quit();
        Application.OpenURL("https://www.zdf.de/show/dalli-dalli/folge1-112.html");
    }
}
