using UnityEngine;

public class IncrementPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1 = 3;
        int number2 = 5;

        int result1 = 0;
        int result2 = 8;

        number1--;                  //2
        result1 = ++number1;        //3 => �����ϰ� ����
        Debug.Log("result: " + result1);    // 3

        ++ number2;                 //6
        result2 = number2--;        //6 => ���� �ϰ� -- ��������
        Debug.Log("result2: " + result2);   // 6
            
        Debug.Log(number2);  // ���ҿ����� ������ 5�� ����!
    }
}
