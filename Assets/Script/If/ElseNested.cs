using UnityEngine;

// else ��ø��
public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = '1';

        // [1] input = 'y' �̸� YES ���
        // [2] intput = 'n' �̸� NO ���
        // [3] intput = �׿� ������ �̸� CANCEL ���

        if(input == 'y')
        {
            Debug.Log("YES");
        }
        else
        {
            if(input == 'n')
                {
                    Debug.Log("NO");
                }
                else
                {
                    Debug.Log("CANCEL");
                }
        }

    }
}
