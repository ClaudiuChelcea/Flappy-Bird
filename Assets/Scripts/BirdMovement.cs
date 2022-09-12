using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D player;
    private AudioSource[] birdSounds;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
        birdSounds = GetComponents<AudioSource>(); // 1 - death, 2 - wing
    }

    // Update is called once per frame
    void Update()
    {
        // Game not started
        if(gameManager.startMenu.active == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameManager.setStart();
                player.velocity = Vector2.up * velocity;
            }
        }
        else if(Input.GetMouseButtonDown(0))
        {
            if (gameManager.loseMenu.active == false)
            {
                player.velocity = Vector2.up * velocity;
                birdSounds[1].Play();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Point") {
            gameManager.score.increaseScore();
        }
        else
        {
            gameManager.setLose();
            birdSounds[0].Play();
        }
    }
}
