using UnityEngine;

public class AppDelegate : MonoBehaviour
{
    private void Awake()
    {
        InAppBrowser.OpenURL("www.google.com");
    }
}
