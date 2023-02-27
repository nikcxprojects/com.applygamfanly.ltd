using UnityEngine.UI;
using UnityEngine;

public class BestScoreContainer : MonoBehaviour
{
    private Text Text { get; set; }

    private void Awake()
    {
        Text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        Text.text = $"{StatsUtility.BestScore}";
    }

    public void ForceUpdate()
    {
        Text.text = $"{StatsUtility.BestScore}";
    }
}
