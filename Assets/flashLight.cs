using UnityEngine;
using Vuforia;

public class flashLight : MonoBehaviour
{
    public void SetFlashLight(bool enabled){
        Debug.Log($"Flashlight: {enabled}");
        CameraDevice.Instance.SetFlashTorchMode(enabled);
    }
}
