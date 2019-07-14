using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshPro scoreText;
    private int score;

    public void Score(int scorePoints) {
        score += scorePoints;
        scoreText.text = String.Format("{0:000}", score);
    }
}
