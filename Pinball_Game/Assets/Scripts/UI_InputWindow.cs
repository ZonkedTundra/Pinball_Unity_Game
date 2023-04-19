using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using CodeMonkey.Utils;
using TMPro;
using UnityEngine;

public class UI_InputWindow : MonoBehaviour
{
    private Button_UI okButton;
    private Button_UI cancelButton;
    private TMP_InputField inputField;
    private TextMeshProUGUI titleText;
    public ScoreManager scoreManager;
    // private Score score;

    private void Awake()
    {
        okButton = transform.Find("okButton").GetComponent<Button_UI>();
        cancelButton = transform.Find("cancelButton").GetComponent<Button_UI>();
        titleText = transform.Find("titleText").GetComponent<TextMeshProUGUI>();
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();

        Hide();
    }

    public void Show(string titleString, string inputString, Action onCancel, Action<string> onOk)
    {
        gameObject.SetActive(true);

        titleText.text = titleString;
        inputField.text = inputString;

        okButton.ClickFunc = () => {
            Hide();
            onOk(inputField.text);
            // score = new Score(inputField.text, KeepScore.score);
            Debug.Log(inputField.text.ToString());
            Debug.Log(KeepScore.score);
            Debug.Log(scoreManager);
            scoreManager.AddScoreSB(new Score(inputField.text.ToString(), KeepScore.score));
            Debug.Log("Scoreboard score added.");
            scoreManager.SaveScore();
        };

        cancelButton.ClickFunc = () =>{
            Hide();
            onCancel();
        };
    }

    public void Hide() 
    {
        gameObject.SetActive(false);
    }
}
