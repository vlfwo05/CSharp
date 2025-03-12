using UnityEngine;

//로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Random클래스 객체(객체,인스턴스) 생성
        System.Random rand = new System.Random();

        // 배열 변수 선언 및 요소수 생성
        int[] numbers = new int[6];

        int number = 0; //랜덤값을 저장하는 변수
        bool flag = false;  //중복 검사해서 중복이면 true, 아니면 false

        for (int i = 0; i < 6; i++)
        {
            // 1~45 랜덤값을 받아온다
            number = rand.Next(1, 46);

            //중복체크 - number와 먼저 뽑힌 로또번호와 비교
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
            if (flag == false)   //중복이 아니면
            {
                numbers[i] = number;
            }
            else //중복이면 다시 계산하기 위해 인덱스 조정한다
            {
                i--;
            }

            //로또번호 출력
            /*for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }*/

        }

        /*
        nunber[0] 중복검사 X
        nunber[1] 중복검사: nunber[0]랑 진행 
        nunber[2] 중복검사: nunber[0], nunber[1]들이랑 진행
        nunber[3] 중복검사: nunber[0], nunber[1], nunber[2]들이랑 진행
        ....


        */

        /*
        System.Random random = new System.Random();
        int a0 = random.Next(1, 46);    // 1번째 숫자
        int a1 = a0;
        if (a1 == a0)
        {
            a1 = random.Next(1, 46);
        }                               // 2번째 숫자


        int a2 = a1;
        if (a2 == a1)   //a0
        {
            a1 = random.Next(1, 46);
        }                               // 3번째 숫자


        int a3 = a2;
        if (a3 == a2)   //a0, a1
        {
            a1 = random.Next(1, 46);
        }                               // 4번째 숫자

        int a4 = a3;
        if (a4 == a3)   //a0, a1, a2
        {
            a1 = random.Next(1, 46);
        }                               // 5번째 숫자

        int a5 = a4;
        if (a5 == a4)   ////a0, a1, a2, a3
        {
            a1 = random.Next(1, 46);
        }                               //6번째 숫자
        */
    }
}
/*
[Q]
로또 번호 생성기 만들기
[1] 6개 번호
[2] 1~45 사이의 랜덤 번호
[3] 중복된 숫자가 나오면 안된다

[output]
1
2
3
4
5
6

*/