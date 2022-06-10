using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizEvent : MonoBehaviour
{
    private bool bQuizstart;
    private int CorretCount = 0;

    public GameObject[] options;

    public Button StartButton;
    public Button AButton;
    public Button BButton;
    public Button EndingButton;

    public int currentQuestion;
    public Text QuestionText;
    public static int state = 0;

    private List<Quizs> quizList = new List<Quizs>();

    void Start()
    {
        quizList.Add(new Quizs("쓰러진 사람을 발견하면 즉시 가슴압박을 해야 한다", 2, "환자의 의식확인,도움요청(자동심장충격기 함께 요청)과 호흡을 확인 후 가슴압박을 시행해야 한다"));
        quizList.Add(new Quizs("쓰러진 사람이 의식이 있는지 확인 할때는 머리를 흔들거나 뺨을 때려본다", 2, "쓰러진 사람의 얼굴을 보면서 양쪽 어깨를 가볍게 두드려 깨워 본다"));
        quizList.Add(new Quizs("호흡이 있는지 확인 할 때는 3초 정도 배와 가슴 움직이는지 관찰한다", 2, "5~10초 이내로 가슴과 배의 움직임이 있는지 관찰한다"));
        quizList.Add(new Quizs("가슴압박의 위치는 가슴의 가운데이다", 1, "가슴뼈 아래쪽의 중간 지점(2분의 1지점) 또는 젖꼭지와 젖꼭지 사이 정중앙을 눌러야 합니다"));
        quizList.Add(new Quizs("성인일 경우 가슴압박 깊이는 약 2cm 이다", 2, "성인의 압박 깊이는 약5cm 이다 "));
        quizList.Add(new Quizs("가슴압박은 분당 100~120회 속도로 실시한다", 1, " '하나', '둘', '셋', ..., '서른'하고 세어가면서 규칙적으로 시행하며, 강하고 빠르게 시행한다"));
        quizList.Add(new Quizs("가슴압박을 하는 동안 환자와 처치자의 팔의 각도는 45도를 유지한다", 2, "팔의 각도는 90도 유지 하면서 팔꿈치는 구부러지지 않게 한다"));
        quizList.Add(new Quizs("심정지시 골든 타임은 10분이다", 2, "패드를 우측 쇄골뼈 아래 와 왼쪽 옆구리에 붙인다"));
        quizList.Add(new Quizs("자동심장 충격기의 패드는 이마와 가슴에 부착한다", 2, "5~10초 이내로 가슴과 배의 움직임이 있는지 관찰한다"));
        quizList.Add(new Quizs("자동심장 충격시에 환자와 접촉해도 된다", 2, "전기 충격시 접촉하고 있다면 감전의 위험이 있기 때문에 위험하다"));

        makeQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void startQuiz()
    {
        QuestionText.text = "";
        
        foreach (Quizs i in quizList)
        {
            state = 0;
            QuestionText.text = i.getText();
            //while (true)
            //{
            //    if (state == i.getAnswer())
            //        CorretCount++;

            //    if (state != 0)
            //        break;
            //    cnt++;
            //    Debug.Log("now looping");
            //    if (cnt > 10000) break;
            //}
        }
    }

    public void aButtonPush()
    {
        state = 1;
    }
    public void bButtonPush()
    {
        state = 2;
    }
    public void quizStartPush()
    {
        AButton.gameObject.SetActive(true);
        BButton.gameObject.SetActive(true);
        StartButton.gameObject.SetActive(false);
        startQuiz();
    }
    void makeQuestion()
    {
        currentQuestion = Random.Range(0, quizList.Count);
        QuestionText.text = quizList[currentQuestion].getText();
    }
    void setAnswer()
    {
        
    }
}

public class Quizs
{
    private string QuestionText;
    private int Answer;
    private string Comment;

    public Quizs(string _text, int _answer, string _comment)
    {
        QuestionText = _text;
        Answer = _answer;
        Comment = _comment;
    }

    public string getText()
    {
        return QuestionText;
    }
    public int getAnswer()
    {
        return Answer;
    }
    public string getComment()
    {
        return Comment;
    }
}