using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Score
{

    public string name;
    public float score;

    public Score(string name, float score)
    {
        this.name = name;
        this.score = score;
    }

}
