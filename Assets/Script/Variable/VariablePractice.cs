using UnityEngine;

public class VariablePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1]���� ����
        int first, second, third;
        
        // [2]������ �� ����
        first = 10;
        second = 20;
        third = 30;

        //[3]�� ���
        Debug.Log(first + "," + second + "," + third);
    }
}


/* 
[Q]
���� : first, second, third ����

[output]
10,20,30
*/