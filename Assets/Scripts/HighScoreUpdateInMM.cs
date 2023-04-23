using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreUpdateInMM : MonoBehaviour
{
    [SerializeField] Text highScoreText;
    private void Start()
    {
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    //public void StartGame()
    //{
    //    SceneManager.LoadScene(1);
    //}
}
