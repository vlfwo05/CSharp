using UnityEngine;

//���ڿ� ���ϱ� - 2���� ���
public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "RedPlus";
        string inputName = "redPlus";

        //[1] ������(==)�� ���
        if (userName.ToLower() == inputName.ToLower()) 
        {
            Debug.Log("[1]�����ϴ�");
        }

        //[2] string.Equal() �޼��� ���
        if(string.Equals(userName, inputName, System.StringComparison.InvariantCultureIgnoreCase))
        {
            Debug.Log("[2]�����ϴ�");
        }    

    }
}
