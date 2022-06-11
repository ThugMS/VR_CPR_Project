using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushBtn : MonoBehaviour
{
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Cuub")
        {   //Tag는 유니티내부의 Inspector 바로 밑에 있음. 직접 Tag를 설정해줘야함.
            // Debug.Log("버튼과 상자 충돌이 감지되었습니다."); 
        }
    }
    // void OnCollisionStay(Collision collision)
    // {
    //     if (collision.collider.tag == "Cuub")
    //     {
    //         Debug.Log("버튼과 상자 계속 충돌중입니다.");
         
    //     }
    // }
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Cuub")
        {
            // Debug.Log("버튼과 상자 충돌이 종료되었습니다.");
            count += 1;
            Debug.Log(count + "심장박동횟수");
        }

    }
}
