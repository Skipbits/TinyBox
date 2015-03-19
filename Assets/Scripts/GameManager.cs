using System;
using _unity;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    protected GameManager()
    {
    }

    private GameStates gameState;
    public string gameName = "TinyBox";
    public GameObject navBar, winMenu;

    [HideInInspector]
    public float moveBarValue = 0f;
    
    public bool constantMove = false;

    public void Initialize()
    {
        _.l("Initializing Game Manager  ...");

        ChangeState(GameStates.init);
    }

    #region Game State Manipulation

    /// <summary>
    /// Returns (GameStates) current Game State
    /// </summary>
    /// <returns></returns>
    public GameStates GetGameState()
    {
        return gameState;
    }

    /// <summary>
    /// Change the state of the GameManager.
    /// Optionally, execute a callback after the transition of the gameState.
    /// Use GameStates enum
    /// </summary>
    /// <param name="localState"></param>
    /// <param name="Callback"></param>
    public void ChangeState(GameStates localState, Action Callback = null)
    {
        gameState = localState;

        switch (gameState)
        {
            case GameStates.init:
                _.l("Game Manager Initialized");

                break;

            case GameStates.active:

                break;

            case GameStates.paused:

                break;

            case GameStates.resume:

                break;

            case GameStates.win:

                break;

            case GameStates.loose:

                break;

            case GameStates.quit:

                break;

            case GameStates.levelInit:
                
                if(Application.loadedLevelName.Length>5 && Application.loadedLevelName.Substring(0,5)=="Level")
                {
                    _.l("Initiaitig Level");
                          }
                else
                {
                    _.l("Not a level");
                  }

                ChangeState(GameStates.active);
                break;
        }

        _.l("[Game Manager] Game State: " + gameState);
        if (Callback != null) Callback();
    }

    #endregion Game State Manipulation

    public void ChangeLevel(int level)
    {
        Application.LoadLevel("Level" + level);

        ChangeState(GameStates.levelInit);
    }
}

#region States

public enum GameStates
{
    init = 0,
    active = 1,
    paused = 2,
    resume = 3, //re-initialize GUI, stuffs, maybe
    win = 4,
    loose = 5,
    quit = 6,
    levelInit = 7
}

//Specifically for Turn Based Game
public enum PlayerStates
{
    spawn = 0,
    waiting = 1, // Not gonna use here
    active = 2,
    done = 3,
    win = 4,
    loose = 5,
    die = 6
}

public enum ShrinkableType
{
    Hero,
    Handler,
    Block,
    Box
}

#endregion States