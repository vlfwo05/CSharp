using NUnit.Framework;
using UnityEngine;

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        object o = i;
        Debug.Log(o);

        object obj = 8974;
        int num = (int)obj;
        Debug.Log(num);

        object s = "�ȳ��ϼ���";
        object j = 4567;
        if(s is string)
        {
            Debug.Log($"[1] {s}�� null�� �ƴϸ� ���ڿ� �������� ��ȯ�� �����մϴ�");
        }
    
        if(j is int)
        {
            Debug.Log($"[2] {j}�� ���������� ��ȯ�� �����մϴ�");
        }
    }
}
/*
�� ���� (vaule type) : ��ü�� �� ��ü�� ��� �ִ� ����
�������� (reference type) : ��ü�� ���� ��� �ְ� �Ǵٸ� ��ü�� �����ͷ� �ٶ󺸴�(����Ű��) ����
 
object ������ ����: object ������ �������� ��� ������ ������ ���� ����(�Ҵ�) ����
�ڽ�(boxing): �� ������ �����͸� ���� ������ �����ͷ� �����ϴ� ��
��ڽ�(unboxing): ���� ������ �����͸� �� ������ �����ͷ� ���� - ĳ����, ĳ��Ʈ


is ������ : ���� ���ϱ�
- Ư�� �������� �ƴ����� ��
- Ư�� �������� ��ȯ�� ���� �ϸ� true, �׷��� ������ false

 
 */