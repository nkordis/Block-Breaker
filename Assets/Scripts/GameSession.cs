using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameSession : MonoBehaviour
{

    //config params
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;

    //state variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
       
        if (gameStatusCount > 1)
        {
            Debug.Log("Destroy " + gameObject.GetInstanceID());
            Destroy(gameObject);
           
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Debug.Log(" Dont destroy  " + gameObject.GetInstanceID());

        }
    }

    internal bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;

    }

    public void AddToScore()
    {
      /*  currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
        */
        FindObjectOfType<GameSession>().currentScore += pointsPerBlockDestroyed;
        FindObjectOfType<GameSession>().scoreText.text = FindObjectOfType<GameSession>().currentScore.ToString();

        Debug.Log(FindObjectOfType<GameSession>().currentScore /*+" add to object "+ gameObject.GetInstanceID()
           */ + "currentScore: " + currentScore + " pointsPerBlockDestroyed: " + pointsPerBlockDestroyed);
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

}
