using System;
using _unity;

public class PlayerManager
{
    private PlayerStates playerState;
    private int _moves;
    private int _timeSpent;
    private string _name;

    public int moves
    {
        get
        {
            return _moves ;
        }
        set
        {
            _moves = value;
        }
    }

    public int timeSpent
    {
        get
        {
            return _timeSpent;
        }
        set
        {
            _timeSpent = value;
        }
    }

    public string name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name can't be Empty.");
            }

            _name = value;
        }
    }

    public PlayerManager()
    {
        _.l("Player Initialized");
        ChangePlayerState(PlayerStates.spawn);
    }

    #region Player State Manipulation

    public PlayerStates GetPlayerState()
    {
        return playerState;
    }

    public void ChangePlayerState(PlayerStates localPlayerState, Action Callback = null)
    {
        playerState = localPlayerState;

        switch (playerState)
        {
            case PlayerStates.spawn:

                break;

            case PlayerStates.waiting:

                break;

            case PlayerStates.active:

                break;

            case PlayerStates.done:

                break;

            case PlayerStates.die:

                break;

            case PlayerStates.win:

                break;

            case PlayerStates.loose:

                break;
        }

        _.l("[Game Manager] Game State: " + playerState);
        if (Callback != null) Callback();
    }

    #endregion Player State Manipulation
}