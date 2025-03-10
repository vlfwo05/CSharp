using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int maxvalue = GetMax(3, 5);
        Debug.Log($"3과 5중 큰 수는 {maxvalue} 이다");

        int minvalue = GetMin(-3, -5);
        Debug.Log($"-3과 -5중 작은 수는 {minvalue} 이다");
    }
    int GetMax(int x, int y)
    {
        /*
        int Max;
        if (x > y)
        {
            Max = x;
        }
        else
        {
            Max = y;
        }
        return Max;              => 1번
        */

        //3항 연산자
        //int Max = (x > y) ? x : y;
        //return Max;           => 2번

        //return (x > y) ? x : y;        => 3번
        
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }              // => 4번
    }

    int GetMin(int x, int y)
    {
        int Min;
        if (x > y)
        {
            Min = y;
        }
        else
        {
            Min = x;
        }
        return Min;
    }
}


/*
[Q]
1. 매개변수로 입력 받은 두개의 정수중 큰수를 반환하는 함수
2. 매개변수로 입력받ㅇ느 두개의 정수중 작은 수를 반환하는 함수
3. 3, 5를 입력받아 큰수를 출력하기
4. -3, -5를 입력받아 작은수를 출력하기

[output]
3과 5중 큰 수는 (반환값) 이다
-3과 -5중 작은 수는 (반환값) 이다
 */