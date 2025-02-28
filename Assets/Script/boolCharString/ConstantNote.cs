using UnityEngine;

public class ConstantNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 
        string name = "홍길동";
        name = "이순신";   //수정 가능 (변수니까)

        //상수
        const int AGE = 20;
        //AGE = 21;   //수정 불가능(상수니까) [AGE를 20으로 고정]
                      //수정하면 오류 발생

        //변수, 상수 사용
        Debug.Log($"{name} - {AGE}");

    }
}
