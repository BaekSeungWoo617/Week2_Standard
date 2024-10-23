using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab; // Ǯ�� ����� ���� ������Ʈ ������
    private List<GameObject> pool = new List<GameObject>(); // ���� ������Ʈ Ǯ
    public int poolSize = 300; // Ǯ�� ũ��

    void Start()
    {

        // �̸� poolSize��ŭ ���� ������Ʈ�� �����ϰ� ��Ȱ��ȭ ���·� �߰�
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab, transform); // �������� �ν��Ͻ�ȭ
            obj.SetActive(false); // ��Ȱ��ȭ, �翬�� �ٷ� ����ϴ°� �ƴ�
            pool.Add(obj); // Ǯ�� �߰��� �߱� ������ GameObject obj �� �����ȴ�
            //���ƾƾƤ��� ������Ʈ Ǯ�� ��ƴ�
        }
    }

    public GameObject Get()
    {
        // ��Ȱ��ȭ�� ���� ������Ʈ�� ã�� Ȱ��ȭ�ϰ� ��ȯ
        foreach (GameObject obj in pool)// ����Ʈ for�����
        {
            if (!obj.activeInHierarchy) // ��Ȱ��ȭ�� ������Ʈ ã��
            {
                obj.SetActive(true); // Ȱ��ȭ
                return obj; // ��ȯ
            }
        }
        return null; // ����� �� �ִ� ������Ʈ�� ���� ���
    }

    public void Release(GameObject obj)
    {
        if (pool.Contains(obj)) // Ǯ�� ���Ե� ������Ʈ���� Ȯ��
        {
            obj.SetActive(false); // ��Ȱ��ȭ
        }

    }
}