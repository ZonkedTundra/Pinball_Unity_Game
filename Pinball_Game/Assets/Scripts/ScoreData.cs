using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ScoreData
{

    public List<Score> scores;

    public ScoreData()
    {
        scores = new List<Score>();
    }

}
