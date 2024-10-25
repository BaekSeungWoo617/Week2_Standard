using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestDataSO", menuName = "QuestDataSO/MonsterQuestDataSO", order = 0)]
public class MonsterQuestDataSO : QuestDataSO
{
    [Header("죽일 몬스터 수")]
    public int NeedMonsterKill;
}
