using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseMenu;
    public GameObject startMenu;
    public GameObject player;
    [SerializeField] public Score score = new Score();
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        score.setScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.scoreText + score.scoreValue.ToString();
    }

    public void setStart()
    {
        Time.timeScale = 1;
        startMenu.SetActive(false);
    }

    public void setLose()
    {
        Time.timeScale = 0;
        loseMenu.SetActive(true);
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
