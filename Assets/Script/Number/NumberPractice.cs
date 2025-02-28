using UnityEngine;

public class NumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float F = 3.14F;
        double B = 3.14D;
        decimal D = 3.14M;

        Debug.Log("float : " + F);
        Debug.Log("double : " + B);
        Debug.Log("decimal : " + D);
    }
}

/*
[Q]
실수형 값 float에 3.14, double에 3.14, decimal에 3.14 값 출력하기


*/