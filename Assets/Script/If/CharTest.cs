using UnityEngine;


public class CharTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char c = 'A';

        //�빮�� �Ǻ���
        if(c >= 'A' && c >='z')
        {
            Debug.Log($"{c}�� �빮�� �Դϴ�");
        }
        else
        {
            Debug.Log($"{c}�� �ҹ��� �Դϴ�");
        }

    }
}
