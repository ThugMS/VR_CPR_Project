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
        quizList.Add(new Quizs("������ ����� �߰��ϸ� ��� �����й��� �ؾ� �Ѵ�", 2, "ȯ���� �ǽ�Ȯ��,�����û(�ڵ�������ݱ� �Բ� ��û)�� ȣ���� Ȯ�� �� �����й��� �����ؾ� �Ѵ�"));
        quizList.Add(new Quizs("������ ����� �ǽ��� �ִ��� Ȯ�� �Ҷ��� �Ӹ��� ���ų� ���� ��������", 2, "������ ����� ���� ���鼭 ���� ����� ������ �ε�� ���� ����"));
        quizList.Add(new Quizs("ȣ���� �ִ��� Ȯ�� �� ���� 3�� ���� ��� ���� �����̴��� �����Ѵ�", 2, "5~10�� �̳��� ������ ���� �������� �ִ��� �����Ѵ�"));
        quizList.Add(new Quizs("�����й��� ��ġ�� ������ ����̴�", 1, "������ �Ʒ����� �߰� ����(2���� 1����) �Ǵ� �������� ������ ���� ���߾��� ������ �մϴ�"));
        quizList.Add(new Quizs("������ ��� �����й� ���̴� �� 2cm �̴�", 2, "������ �й� ���̴� ��5cm �̴� "));
        quizList.Add(new Quizs("�����й��� �д� 100~120ȸ �ӵ��� �ǽ��Ѵ�", 1, " '�ϳ�', '��', '��', ..., '����'�ϰ� ����鼭 ��Ģ������ �����ϸ�, ���ϰ� ������ �����Ѵ�"));
        quizList.Add(new Quizs("�����й��� �ϴ� ���� ȯ�ڿ� óġ���� ���� ������ 45���� �����Ѵ�", 2, "���� ������ 90�� ���� �ϸ鼭 �Ȳ�ġ�� ���η����� �ʰ� �Ѵ�"));
        quizList.Add(new Quizs("�������� ��� Ÿ���� 10���̴�", 2, "�е带 ���� ���� �Ʒ� �� ���� �������� ���δ�"));
        quizList.Add(new Quizs("�ڵ����� ��ݱ��� �е�� �̸��� ������ �����Ѵ�", 2, "5~10�� �̳��� ������ ���� �������� �ִ��� �����Ѵ�"));
        quizList.Add(new Quizs("�ڵ����� ��ݽÿ� ȯ�ڿ� �����ص� �ȴ�", 2, "���� ��ݽ� �����ϰ� �ִٸ� ������ ������ �ֱ� ������ �����ϴ�"));

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