using UnityEngine;

//반환값이 있는 함수 만들고 호출하기
public class ReturneValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 반환값이 있는 함수 호출
        //반환값을 받아줄 변수 선언한고 반환되는 값 저장
        string  returnVale = Getstring();
        Debug.Log(returnVale);
    }

    //[1] 반환값이 있는 함수 만들기(선언, 정의)
    //반환값 이라는 문자열(string)을 반환하는 함수
    string Getstring()
    {
        return "반환값(return Value";
    }

}
