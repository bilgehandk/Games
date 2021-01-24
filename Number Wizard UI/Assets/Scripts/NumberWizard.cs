﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min,max);
        guessText.text = guess.ToString();
    }
}