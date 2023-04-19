using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreUI : MonoBehaviour
{
    public RowUI rui;
    public ScoreManager sm;

    // Start is called before the first frame update
    void Start()
    {
        var scores = sm.GetHighScores().ToArray();
        var limit = 4;
        // Only display the top 5 results (i begins at 0)
        if (scores.Length <= limit)
        {
            limit = scores.Length;
        }
        for (int i = 0; i < limit; i++)
        {
            var row = Instantiate(rui, transform).GetComponent<RowUI>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}
