using UnityEngine;

// break로 무한루프 빠져 나오기
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
                for(; ;)
                {

                }

                while(true)
                {

                }
        */
        int number = 6;

        //number가 5이상이면 while문 종료
        while(true)
        {
            //반복 실행문
            Debug.Log(number);

            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
