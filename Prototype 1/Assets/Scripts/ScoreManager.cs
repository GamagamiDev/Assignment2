/* Colin Gamagami
 * Assignment 2
 * Handles the game over state and scoring
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textBox;

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if the game is not over, display score
        if (!gameOver)
        {
            textBox.text = "Score: " + score;
        }

        //win condition: 3 or more points
        if (score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textBox.text = "You win!\nPress R to try again.";
            }
            else
            {
                textBox.text = "You lose!\nPress R to try again.";
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
