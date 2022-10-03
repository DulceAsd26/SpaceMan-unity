using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    menu, 
    inGame,
    gameOver
}


public class GameManager : MonoBehaviour {

    public GameState currentGameState = GameState.menu;


    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

    }

    public void StartGame(){
        //Start
    }

    public void GameOver(){
        //GameOver
    }

    public void BackToMenu(){
       //Back
    }

    private void SetGameState(GameState newGameSate){
        if(newGameSate == GameState.menu){
            //TODO: colocar la lógica del menú 
        }else if(newGameSate == GameState.inGame){
            //TODO: hay que preparar la escena para jugar
        }else if(newGameSate == GameState.gameOver){
            //TODO: preparar el juego para el Game Over
        }


        this.currentGameState = newGameSate;
    }


}
    

