using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int ScoreValue = 10;
    Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreValue = 10;
        ScoreText = GetComponent<Text>();
        Highscore.HighscoreValue = ScoreValue;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text ="Score: "+ ScoreValue;
    }
}
