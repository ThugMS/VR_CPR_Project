using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> qna;
    public GameObject[] options;
    public static int currentQuestion = 0;
    public Text QuestionText;
    public GameObject background;
    public GameObject QuizPanel;
    public GameObject CommentPanel;

    //public GameObject abutton;
    //public GameObject bbutton;

    public Text ScoreText;
    public Text CommentText;
    int TotalQuestions=0;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        TotalQuestions = qna.Count;
        background.SetActive(false);
        CommentPanel.SetActive(false);
        makeQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void makeQuestion()
    {
        if (qna.Count > 0)
        {
            currentQuestion = Random.Range(0, qna.Count);
            QuestionText.text = qna[currentQuestion].Question;
            setAnswer();
        }
        else
        {
            Debug.Log("end");
            GameOver();
        }
        
    }

    void setAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<Answer>().buttonColor;
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = qna[currentQuestion].Answers[i];
            if(qna[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }
    public void correct()
    {
        Score += 1;
        qna.RemoveAt(currentQuestion);
        //makeQuestion();
        StartCoroutine(waitForNext(1));
        
    }
    public void wrong()
    {
        qna.RemoveAt(currentQuestion);
        //makeQuestion();
        StartCoroutine(waitForNext(1));
    }
    //public void showComment()
    //{
    //    CommentPanel.SetActive(true);
    //    QuizPanel.SetActive(false);
    //    Debug.Log(currentQuestion);

    //    CommentText.text = qna[currentQuestion].Comment;
    //    StartCoroutine(waitForNext(3));

    //    CommentPanel.SetActive(false);
    //    QuizPanel.SetActive(true);
    //}

    IEnumerator waitForNext(int i)
    {
        yield return new WaitForSeconds(i);
        makeQuestion();
    }

    void GameOver()
    {
        QuizPanel.SetActive(false);
        background.SetActive(true);
        ScoreText.text = Score*10 +"점입니다";
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //void changeColor(Button _b)
    //{
    //    ColorBlock colorBlock = _b.colors;

    //    //(r, g, b, a) 기준 빨간색으로 normal Color 지정
    //    colorBlock.normalColor = new Color(110, 138, 226, 255);

    //    _b.colors = colorBlock;
    //}
}
