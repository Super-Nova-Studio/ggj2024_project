using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event EventHandler OnStateChanged;

    [SerializeField] private ScoreManager scoreManager;

    private enum State
    {
        WaitingStatus,
        CountdownStatus,
        GamePlay,
        GameOver,
    }

    private State state;
    private float waitingStatusTimer = 1f;
    private float countdownStatusTimer = 3f;

    private void Awake()
    {
        Instance = this;
        state = State.WaitingStatus;
    }

    private void Update()
    {
        switch (state)
        {
            case State.WaitingStatus:
                waitingStatusTimer -= Time.deltaTime;
                if (waitingStatusTimer < 0f)
                {
                    state = State.CountdownStatus;
                    OnStateChanged?.Invoke(this, EventArgs.Empty);
                }
                break;
            case State.CountdownStatus:
                countdownStatusTimer -= Time.deltaTime;
                if (countdownStatusTimer < 0f)
                {
                    state = State.GamePlay;
                    OnStateChanged?.Invoke(this, EventArgs.Empty);
                }
                break;
            case State.GamePlay:
                break;
            case State.GameOver:

                break;
        }
    }

    public bool IsCountdownToStartActive()
    {
        return state == State.CountdownStatus;
    }

    public float GetCountdownToStartTimer()
    {
        return countdownStatusTimer;
    }
    
    public bool IsGamePlaying()
    {
        return state == State.GamePlay;
    }

    public bool IsGameOver()
    {
        return state == State.GameOver;
    }

    public void SetGameOver()
    {
        if (state == State.GamePlay)
        {
            state = State.GameOver;
            OnStateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}