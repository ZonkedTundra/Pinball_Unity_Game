using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey;
using System.Linq;

public class GOScore : MonoBehaviour
{
    public TMP_Text Score;
    public ScoreManager _sm;
    [SerializeField] private UI_InputWindow _iw;
    public bool nameEntryShown;

    // Start is called before the first frame update
    void Start()
    {
        nameEntryShown = false;
        EntryShower();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EntryShower()
    {
        if (KeepScore.score != 0)
        {
            Score.text = "Score: " + KeepScore.score.ToString();
            var scores = _sm.GetHighScores().ToArray();
            // Using the "&& nameEntryShown == false" means that, in theory, the InputWindow should only pop up once -- no problems should be caused.
            if (scores.Length > 5)
            {
                if (KeepScore.score > scores[4].score && nameEntryShown == false)
                {
                    NameEntryShow();
                    nameEntryShown = true;
                    Debug.Log("Name entry being shown.");
                }
            }
            else
            {
                NameEntryShow();
                nameEntryShown = true;
                Debug.Log("Name entry being shown.");
            }
        }
    }

    void NameEntryShow()
    {
        _iw.Show("Enter your name", "name", () => { CMDebug.TextPopupMouse("Cancel"); }, (string inputText) => { CMDebug.TextPopupMouse("Ok" + inputText); });
    }
}
