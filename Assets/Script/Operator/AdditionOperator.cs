using UnityEngine;

// + : 더하기 연산의 추가 기능
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hellow" + " World!!!");  //문자연 더하기
        Debug.Log("Hi" + " " + "Everyone");  

        Debug.Log("123" + "456");   //123456    문자열 + 문자열 => 문자열
        Debug.Log("123" + 456);     //123456    문자열 + 숫자 => 문자열

        Debug.Log(123 + "456" + 789 + 890); //1234567890    //숫자 + 문자열 + 숫자 + 숫자 => 문자열
        Debug.Log(123 + 456);               //579     //숫자 + 숫자 => 숫자

        Debug.Log("123" + true);               //1231   //문자열 + bool형 => 문자열

        //Debug.Log("123" - 456);    //문자열에서 정수형 데이터 빼기는 없음
    }
}
