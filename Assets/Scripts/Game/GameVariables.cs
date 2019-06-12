﻿using System;
public static class GameVariables
{
    public static float TimeRemaining;
    public static int CurrentLevel;
    public static int CurrentDifficulty;
    public static int Seed;
    public static bool IsGameOver;
    public static int TotalTimeTaken;
    public static int Health;
    public static GameType GameType;

    public static void Reset()
    {
        TimeRemaining = Constants.INITIAL_LEVEL_TIME;
        CurrentLevel = 0;
        CurrentDifficulty = Constants.STARTER_LEVEL_DIFFICULTY;
        Seed = -1;
        IsGameOver = false;
        TotalTimeTaken = 0;
        Health = 3;
        GameType = GameType.Standard;
    }

    public static void Reset(GameType type)
    {
        TimeRemaining = Constants.INITIAL_LEVEL_TIME;
        CurrentLevel = 0;
        CurrentDifficulty = Constants.STARTER_LEVEL_DIFFICULTY;
        Seed = -1;
        IsGameOver = false;
        TotalTimeTaken = 0;
        Health = 3;
        GameType = type;
    }
}