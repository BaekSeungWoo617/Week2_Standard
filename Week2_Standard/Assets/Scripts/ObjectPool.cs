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
            GameObject obj = Instantiate(prefab); // �������� �ν��Ͻ�ȭ
            obj.SetActive(false); // ��Ȱ��ȭ
            pool.Add(obj); // Ǯ�� �߰�
        }
    }

    public GameObject Get()
    {
        // ��Ȱ��ȭ�� ���� ������Ʈ�� ã�� Ȱ��ȭ�ϰ� ��ȯ
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy) // ��Ȱ��ȭ�� ������Ʈ ã��
            {
                obj.SetActive(true); // Ȱ��ȭ
                return obj; // ��ȯ
            }
        }

        Debug.LogWarning("Ǯ���� ����� �� �ִ� ���� ������Ʈ�� �����ϴ�!");
        return null; // ����� �� �ִ� ������Ʈ�� ���� ���
    }

    public void Release(GameObject obj)
    {
        if (pool.Contains(obj)) // Ǯ�� ���Ե� ������Ʈ���� Ȯ��
        {
            obj.SetActive(false); // ��Ȱ��ȭ
        }
        else
        {
            Debug.LogError("Ǯ�� ���Ե��� ���� ������Ʈ�� ��ȯ�� �� �����ϴ�!");
        }
    }
}