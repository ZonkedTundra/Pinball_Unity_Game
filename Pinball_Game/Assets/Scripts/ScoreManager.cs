using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    private ScoreData sd;

    void Awake()
    {
        var json = PlayerPrefs.GetString("scores", "{}");
        Debug.Log(json);
        sd = JsonUtility.FromJson<ScoreData>(json);
        Debug.Log(sd);
    }

    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderByDescending(x => x.score);
    }

    public void AddScoreSB(Score score)
    {
        sd.scores.Add(score);
    }

    public void OnDestroy()
    {
        // All scores will be saved -- this might need to be changed in the future because of size constraints with Set/GetString methods.
        SaveScore();
    }

    public void SaveScore()
    {
        var json = JsonUtility.ToJson(sd);
        PlayerPrefs.SetString("scores", json);
    }
}
