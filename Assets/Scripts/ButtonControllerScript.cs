
using UnityEngine;
using System.Runtime.InteropServices;

public class ButtonControllerScript : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void startSwiftCodeKitController();

    public void OnPressButton()
    {
        startSwiftCodeKitController();
    }
}