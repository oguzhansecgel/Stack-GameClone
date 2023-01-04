using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public int score;
    private int oguz = 5;
    private TextMeshProUGUI text;

    public int myInt()
    {
        return oguz;
    }
    private void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();

        GameManager.OnCubeSpawned += GameManager_OnCubeSpawned;
    }
    private void OnDestroy()
    {
        GameManager.OnCubeSpawned -= GameManager_OnCubeSpawned;

    }
    private void GameManager_OnCubeSpawned()
    {
        score++;
        text.text = "Score : " + (score-1);

    }

    
}
