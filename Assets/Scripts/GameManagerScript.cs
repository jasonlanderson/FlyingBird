using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManagerScript
{
    public static float spawnRate = 2;
    public static float heightOffset = 5;

    enum Difficulty { Easy, Medium, Hard }
    public static Dictionary<string, float> SpawnRateDifficulty = new Dictionary<string, float>(){
        { "Easy", 3.5f},
        { "Medium", 2f},
        { "Hard", 1.5f}
    };

    public static Dictionary<string, float> HeightOffsetDifficulty = new Dictionary<string, float>(){
        { "Easy", 5},
        { "Medium", 10},
        { "Hard", 15}
    };

    public static void StartGame(string difficulty)
    {
        // Set the spawnRate and heightOffsets
        spawnRate = SpawnRateDifficulty[difficulty];
        heightOffset = HeightOffsetDifficulty[difficulty];

        // Load new scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public static void ReturnToTitleScreen()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScene");
    }
}
