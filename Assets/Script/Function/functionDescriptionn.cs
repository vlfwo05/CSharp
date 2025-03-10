using UnityEngine;

public class functionDescriptionn : MonoBehaviour
{
    //[1] show 매서드(함수) 선언, 정의
    void Show()
    {
        Debug.Log("Hello World!!!");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] show 함수 호출
        Show();     // 매개변수 X, 반환값 X
    }
}
/*
Function(함수) / Method(메서드)
: 반복해서 사용하도록 만들어진 하나 이상의 명령문으로 구성된 코드불록

-내장 함수 : 닷넷(C#)에서 제공하는 함수, 유니티에서 제공하는 함수
-사용자 함수 : 개발자 함수

-매개변수가 없는 함수
-매개변수가 있는 함수
-반환값이 

void 함수이름()
{
    //하나 이상의 명령문
    //....
}

void 함수이름(매개변수)
{
    //하나 이상의 명령문
    //....
}

(데이터 타입) 함수이름(매개변수)
{
    //하나 이상의 명령문
    //....

    returne 변수(값);
}

//함수 구성
입력 -> 처리(연산) -> 출력


//함수(매서드)
 [1] 함수 선언 (기능 구현)
 [2] 함수 호출 (기능 사용)


*/