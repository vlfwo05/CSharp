using UnityEngine;

public class ClassMember
{
    //[1] ����(static) �ż���
    public static void StaticMethod()
    {
        Debug.Log("[1] ����(static) �ż���");
    }

    //[2] �ν��Ͻ�(Instancce) �ż���
    public void InstanceMethod()
    {
        Debug.Log("'[2] �ν��Ͻ�(Instancce) �ż���");
    }


}
