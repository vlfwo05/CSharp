using UnityEngine;

//

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4! = 1* 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        //For Factorial
        Debug.Log(FactorialFor(4));
    }

    //For�� �̿� Factorial �� ���ϱ�
    int FactorialFor(int n)
    {
        int result = 1;
            
            for(int i =1;  i <= n; i++)
        {
            result = result * i;
        }

        return result;
    }

    // 3�� �����ڸ� �̿��� Facctorial �����
    int Factor(int n)
    {
        /*if (n <= 1)
            return 1;
        return n * Factorial(n - 1);*/

        return (n > 1) ? n * Factorial(n - 1) : 1;
    }



    //����Լ� �̿� Factorial �� ���ϱ�
    int Factorial(int n)
    {
        //���� ���� �κ�
        if(n == 1)
        {
            return 1;
        }    

        //��� ȣ�� �κ�
        return n * Factorial(n - 1);    
    }    
    /*
             4 * Factorial(3)
                3 * Factorial(2)
                    2 * Factorial(1)
                        1 * Factorial(0)
                            0 * Factorial(-1)
                                -1 * Factorial(-2)
                                    ....
    


    */

}

/*
 ����Լ� : �Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ���ϴ� �Լ�
- ����Լ� �Ű����� : �Ű������� ����, ������ �ȴ�
- ����Լ� �ڵ� ��Ͼȿ��� ����ϸ����� ���� �� �� �ִ� ������ �ʿ��ϴ�

Factorial (n!)

*/