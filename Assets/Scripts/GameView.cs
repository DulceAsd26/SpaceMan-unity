using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour {

    public Text coinsText, scoreText, maxScoreText;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if(GameManager.sharedInstance.currentGameState == GameState.inGame){
            int coins = 0;
            float score = 0;
            float maxScore = 0;

            coinsText.text = coins.ToString();
            scoreText.text = "Score: " + score.ToString("f1");
            maxScoreText.text = "MaxScore: " + maxScore.ToString("f1");
        }
    }
}
