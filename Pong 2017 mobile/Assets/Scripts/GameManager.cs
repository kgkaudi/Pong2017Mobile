using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int playerScore;
    public int opponentScore;
    public Text playerText;
    public Text opponentText;
    public Text winText;

    public void addPlayerScore () {
        playerScore++;
        playerText.text = "Player 1: " + playerScore;
        if (playerScore == 5)
        {
            winText.text = "Player 1 Wins";
            Invoke("restart", 1);
        }
    }

    public void addOpponentScore()
    {
        opponentScore++;
        opponentText.text = "Player 2: " + opponentScore;
        if (opponentScore == 5)
        {
            winText.text = "Player 2 Wins";
            Invoke("restart", 1);
        }
    }
    void restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
