using UnityEngine;

public class VariablePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1]변수 정의
        int first, second, third;
        
        // [2]변수에 값 저장
        first = 10;
        second = 20;
        third = 30;

        //[3]값 출력
        Debug.Log(first + "," + second + "," + third);
    }
}


/* 
[Q]
변수 : first, second, third 정의

[output]
10,20,30
*/