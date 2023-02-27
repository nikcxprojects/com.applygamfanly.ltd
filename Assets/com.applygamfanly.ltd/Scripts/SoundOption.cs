using UnityEngine.UI;
using UnityEngine;

public class SoundOption : MonoBehaviour
{
    private void Start()
    {
        Text textComponent = GetComponentInChildren<Text>();
        GetComponent<Button>().onClick.AddListener(() =>
        {
            AudioListener.pause = !AudioListener.pause;
            textComponent.text = $"SOUND {(AudioListener.pause? "OFF" : "ON")}";
        });
    }
}
