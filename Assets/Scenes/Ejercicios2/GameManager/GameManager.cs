using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour

    {

    GameState currentGameState = GameState.Menu;
    static GameManager gameManager;
    public int vida;
    static GameManager Instance;

    private void Awake()

    {
        Instance = this;
    }
    public void salud (int pvd)
    {
        vida += pvd;
    }

    public static GameManager GetInstance()
    {
        return Instance;
    }

    public enum GameState
    {
        Menu,
        InGame,
        GameOver
    }

    //Empieza el juego// 
    public void StartGame()
    {
        ChangeGameState(GameState.InGame);
    }

    public void InGame()
    {
        ChangeGameState(GameState.InGame);
    }

    //  Se llama cuanado el jugador muere//
    public void GameOver()
    {
        ChangeGameState(GameState.GameOver);
    }

    public void BackToMainMenu()
    {
        ChangeGameState(GameState.Menu);
    }

    void ChangeGameState(GameState newGamestate)
    {
        
      
        switch (newGamestate)
        {
            case GameState.Menu:
                break;

            case GameState.InGame:
                break;

            case GameState.GameOver:
                break;

            default:
                currentGameState = GameState.Menu;
                break;

        }

    }
    
   

         
   
    //public void BackToMainMenu()

  //  {
      //  ChangeGameState(GameState.Menu);//
    //}//


   
 

    public class CollisionEnemy : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "player") ;
            {
                playercontroller.
                    print("jugador tocado");

            }

        }

        static playercontroller PlayerInstance;

       // private void Awake()
       // {
            //PlayerInstance = this;//
       // }//

        public static playercontroller GetInstance()
        {
            return PlayerInstance;
        }

    }
}