using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scoreValue = 0;
    public string scoreText = "Score: ";
    private AudioSource audioScoring;

    private void Start()
    {
        audioScoring = GetComponent<AudioSource>();
    }

    public void increaseScore()
    {
        ++scoreValue;
        audioScoring.Play();
    }

    public void setScore(int score)
    {
        scoreValue = score;
    }
}
