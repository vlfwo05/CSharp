using UnityEngine;
using UnityEngine.Rendering;

//���ڿ� ���� ���(���ڿ� �ٹ̱�): 3����
public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firstName = "�浿";
        var lastName = "ȫ";

        //output: "�̸�: ȫ�浿"

        //[1] string ���ϱ�(+) ������ ���
        displayName = "�̸�: " + lastName + firstName;
        Debug.Log(displayName);

        //[2] string.Format() �޼��� ���
        displayName = string.Format("�̸�: {0}{1}", lastName, firstName);
        Debug.Log(displayName);

        //[3] ���ڿ� ������ ���
        displayName = $"�̸�: {lastName}{firstName}";
        Debug.Log(displayName);

    }
}
