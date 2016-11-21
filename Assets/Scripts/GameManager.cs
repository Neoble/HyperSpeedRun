using UnityEngine;
using System.Collections;

public enum GameState
{
    start,
    playing,
    dead
};

public class GameManager : MonoBehaviour

{
    public static GameState gameState { get; internal set; }
    
    public static class Constants
    {
        public static readonly string PlayerTag = "Player";
        public static readonly string AnimationStarted = "started";
        public static readonly string AnimationJump = "jump";
        public static readonly string WidePathBorderTag = "WidePathBorder";

        public static readonly string StatusTapToStart = "Tap to start";
        public static readonly string StatusDeadTapToStart = "Dead. Tap to start";

    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
    protected GameManager()
    {
        GameState = GameState.start;
        CanSwipe = false;
    }

    public GameState GameState { get; set; }

    public bool CanSwipe { get; set; }

    public void Die()
    {
        UIManager.Instance.SetStatus(Constants.StatusDeadTapToStart);
        this.GameState = GameState.dead;
    }
}
