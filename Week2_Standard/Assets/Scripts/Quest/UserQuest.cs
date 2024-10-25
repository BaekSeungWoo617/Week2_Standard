using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserQuest : MonoBehaviour
{
    public QuestDataSO[] questDataSO;
    private void Awake()
    {
    }
    public void QuestDataSOShow(int index)
    {

        if (index < 0 || index >= questDataSO.Length || questDataSO[index] == null)
        {
            Debug.Log("잘못된 입력입니다.");
            return;
        }
        Debug.Log($"유저의 {index}번째 쿼스트 이름 : {questDataSO[index].QuestName}, 최소레벨 : {questDataSO[index].QuestRequiredLevel}, 퀘스트를 주는 NPC의 id : {questDataSO[index].QuestNPC}");

        if (questDataSO[index] is EncounterQuestDataSO encounterQuest)
        {
            Debug.Log($"대화할 NPC 이름 : {encounterQuest.NPCName}");
        }
        if (questDataSO[index] is MonsterQuestDataSO monsterterQuest)
        {
            Debug.Log($"죽일 몬스터 수 : {monsterterQuest.NeedMonsterKill}");

        }
    }

    private void Start()
    {
        for(int i=0;i< questDataSO.Length;i++)
        {
        QuestDataSOShow(i);
        }

    }
}
