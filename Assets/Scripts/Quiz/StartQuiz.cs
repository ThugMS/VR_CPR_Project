using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuiz : MonoBehaviour
{
    public GameObject QuizManager;
    public GameObject StartPanel;
    public GameObject QuizPanel;


    public void QuizStart()
    {
        StartPanel.SetActive(false);
        QuizPanel.SetActive(true);
        QuizManager.SetActive(true);
    }
}
