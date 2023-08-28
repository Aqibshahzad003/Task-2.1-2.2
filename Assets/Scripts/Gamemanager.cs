using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public TextMeshProUGUI scoretxt;
    public TextMeshProUGUI startxt;

    private int score;
    private int starint;
    

    public void AddScore()
    {
        score++;
        scoretxt.text= "SCORE: " + score.ToString();

        if(score % 3 == 0 )
        {
            AddStar();
        }
    }
    public void AddStar()
    {
        starint++;
        startxt.text ="STAR: " + starint.ToString();
    }
}
