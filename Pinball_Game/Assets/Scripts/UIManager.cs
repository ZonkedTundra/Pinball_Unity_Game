using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public static int lives;

    [SerializeField]
    private Text _scoreText;

    [SerializeField]
    private Text livesText;



    

    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + 0;

        lives = 3;
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            livesText.text = "Lives: " + lives;
        }

    }

    public void UpdateScore(int score)
    {
        Debug.Log("Score increased!");
        _scoreText.text = "Score: " + score;
    }
}
