using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    GameObject[] monster;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    void Start()
    {
        // �̸� poolSize��ŭ ���ӿ�����Ʈ�� �����Ѵ�.
        foreach(var pool in poolSize)
        {
            for (int i = 0; i < poolSize; i++)
            {
                List<GameObject> monster = new List<GameObject>();
                monster = Instantiate(pool.prefab);
                monster.SetActive(false);
            }
        }


    }

    public GameObject Get()
    {
        // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�.
    }

    public void Release(GameObject obj)
    {
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
    }

}