using UnityEngine;

// break�� ���ѷ��� ���� ������
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

        //number�� 5�̻��̸� while�� ����
        while(true)
        {
            //�ݺ� ���๮
            Debug.Log(number);

            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
