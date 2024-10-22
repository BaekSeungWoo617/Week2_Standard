using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuestDataSO", menuName = "QuestDataSO/EncounterQuestDataSO", order = 0)]
class EncounterQuestDataSO : QuestDataSO
{
    [Header("대화할 NPC 이름")]
    public string NPCName;
}