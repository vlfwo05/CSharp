using UnityEngine;

//���� �̿��� ������ ���� : bool, char, string
//char(����) : ���ڵ����� ����
public class CharicterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] char �� ���� ���� �� �ʱ�ȭ
        char grade = 'A';
        char kor = '��';

        //[2] ����ϱ�
        Debug.Log("grade : " + grade);
        Debug.Log("kor : " + kor);
    }
}
