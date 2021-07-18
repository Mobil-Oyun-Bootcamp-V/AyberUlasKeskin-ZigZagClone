using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{ public enum GameState 
    {
        Start,
        Main,
        GameOver,
    }
    private GameState _currentGameState;
    public GameState CurrentGameState
    {
        get { return _currentGameState;}
        set
        {
            switch (value)
            {
                case GameState.Start:
                    break;
                case GameState.Main:                       
                    break;
                case GameState.GameOver:                        
                    break;
            }
            _currentGameState = value;
        }           
    }
    public void ToStart()
    {
        CurrentGameState = GameState.Start;
    }
    public void ToMain()
    {
        CurrentGameState = GameState.Main;
    }
    public void ToGameOver()
    {
        CurrentGameState = GameState.GameOver;
    }

    public void Restart()
    {
        ToStart();
        UIManager.instance.GameStart();
    }

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
