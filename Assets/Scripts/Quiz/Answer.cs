using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public Color buttonColor;


    private void Start()
    {
        buttonColor = GetComponent<Image>().color;
    }
    public void Answers()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("정답");
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("오답");
            quizManager.wrong();
        }
        //quizManager.showComment();
    }
}
