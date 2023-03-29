using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score;
    // public Text highscoreText;
    public static int scoreValue;
    // int highscore = 0;
    public GameObject Panel;
    public GameObject Panel2;


    // Start is called before the first frame update
    void Start()
    {
        //score = GetComponent<Text>();
    }

    public void Update()
    {
        score.text = "score: " + scoreValue.ToString();
        Debug.Log(scoreValue);

        if(scoreValue >= 200)
        {
            Panel.SetActive(true);
        }
        if (scoreValue >= 500)
        {
            Panel2.SetActive(true);
        }
    }
}
