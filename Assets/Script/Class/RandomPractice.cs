using UnityEngine;

//�ζ� ��ȣ ������
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //RandomŬ���� ��ü(��ü,�ν��Ͻ�) ����
        System.Random rand = new System.Random();

        // �迭 ���� ���� �� ��Ҽ� ����
        int[] numbers = new int[6];

        int number = 0; //�������� �����ϴ� ����
        bool flag = false;  //�ߺ� �˻��ؼ� �ߺ��̸� true, �ƴϸ� false

        for (int i = 0; i < 6; i++)
        {
            // 1~45 �������� �޾ƿ´�
            number = rand.Next(1, 46);

            //�ߺ�üũ - number�� ���� ���� �ζǹ�ȣ�� ��
            flag = false;
            if(i > 0)
            {
                for(int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;                    }
                }
            }

            //
            if (flag == false)   //�ߺ��� �ƴϸ�
            {
                numbers[i] = number;
            }
            else //�ߺ��̸� �ٽ� ����ϱ� ���� �ε��� �����Ѵ�
            {
                i--;
            }

            //�ζǹ�ȣ ���
            /*for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }*/

        }

        /*
        nunber[0] �ߺ��˻� X
        nunber[1] �ߺ��˻�: nunber[0]�� ���� 
        nunber[2] �ߺ��˻�: nunber[0], nunber[1]���̶� ����
        nunber[3] �ߺ��˻�: nunber[0], nunber[1], nunber[2]���̶� ����
        ....


        */

        /*
        System.Random random = new System.Random();
        int a0 = random.Next(1, 46);    // 1��° ����
        int a1 = a0;
        if (a1 == a0)
        {
            a1 = random.Next(1, 46);
        }                               // 2��° ����


        int a2 = a1;
        if (a2 == a1)   //a0
        {
            a1 = random.Next(1, 46);
        }                               // 3��° ����


        int a3 = a2;
        if (a3 == a2)   //a0, a1
        {
            a1 = random.Next(1, 46);
        }                               // 4��° ����

        int a4 = a3;
        if (a4 == a3)   //a0, a1, a2
        {
            a1 = random.Next(1, 46);
        }                               // 5��° ����

        int a5 = a4;
        if (a5 == a4)   ////a0, a1, a2, a3
        {
            a1 = random.Next(1, 46);
        }                               //6��° ����
        */
    }
}
/*
[Q]
�ζ� ��ȣ ������ �����
[1] 6�� ��ȣ
[2] 1~45 ������ ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ�

[output]
1
2
3
4
5
6

*/