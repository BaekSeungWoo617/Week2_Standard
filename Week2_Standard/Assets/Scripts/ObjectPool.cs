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
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
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
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
    }

}