using OneSignalSDK;
using UnityEngine;

public class OneSignalInitializer : MonoBehaviour
{
    private void Start() => OneSignal.Default.Initialize("21bf956b-be00-4f0d-b2e8-b5793bf744ce");
}
