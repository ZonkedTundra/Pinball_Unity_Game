using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    private int score;
    private UIManager _UIManager;

    void Start()
    {
        _UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (_UIManager == null)
        {
            Debug.LogError("Cannot find UIManager method in Canvas :(");
        }
    }

    public void AddPoints(int pointsToAdd)
    {
        Debug.Log("Points added.");
        score += pointsToAdd;
        _UIManager.UpdateScore(score);
    }


}
