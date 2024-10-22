using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab; // 풀에 사용할 게임 오브젝트 프리팹
    private List<GameObject> pool = new List<GameObject>(); // 게임 오브젝트 풀
    public int poolSize = 300; // 풀의 크기

    void Start()
    {
        // 미리 poolSize만큼 게임 오브젝트를 생성하고 비활성화 상태로 추가
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab); // 프리팹을 인스턴스화
            obj.SetActive(false); // 비활성화
            pool.Add(obj); // 풀에 추가
        }
    }

    public GameObject Get()
    {
        // 비활성화된 게임 오브젝트를 찾아 활성화하고 반환
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy) // 비활성화된 오브젝트 찾기
            {
                obj.SetActive(true); // 활성화
                return obj; // 반환
            }
        }

        Debug.LogWarning("풀에서 사용할 수 있는 게임 오브젝트가 없습니다!");
        return null; // 사용할 수 있는 오브젝트가 없을 경우
    }

    public void Release(GameObject obj)
    {
        if (pool.Contains(obj)) // 풀에 포함된 오브젝트인지 확인
        {
            obj.SetActive(false); // 비활성화
        }
        else
        {
            Debug.LogError("풀에 포함되지 않은 오브젝트를 반환할 수 없습니다!");
        }
    }
}