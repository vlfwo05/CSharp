using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� 5���� 1�� ����
        //�ʱ��
        int i = 1;

        while (i <= 5)//���ǽ�
        {
            Debug.Log($"ī��Ʈ�ٿ� : {i}");


            //������
            i++;
        }
            Debug.Log("=================");
        
        { 
            int j = 5;

            while(j >= 1)
            {
                Debug.Log($"ī��Ʈ�ٿ� : {j}");

                j--;
            }
        }

    }
}
