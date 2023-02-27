using UnityEngine;

public static class StatsUtility
{
    public static int Level
    {
        get => PlayerPrefs.GetInt("level", 1);
        set => PlayerPrefs.SetInt("level", value);
    }

    public static int BestScore
    {
        get => PlayerPrefs.GetInt("bestscore", 0);
        set => PlayerPrefs.SetInt("bestscore", value);
    }
}
