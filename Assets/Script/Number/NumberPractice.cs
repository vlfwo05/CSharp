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
�Ǽ��� �� float�� 3.14, double�� 3.14, decimal�� 3.14 �� ����ϱ�


*/