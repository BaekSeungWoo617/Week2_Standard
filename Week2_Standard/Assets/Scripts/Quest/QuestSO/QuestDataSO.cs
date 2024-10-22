using System.Collections;
using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName ="QuestDataSO",menuName = "QuestDataSO/QuestDataSO", order =0)]
public class QuestDataSO : ScriptableObject
{
    [Header("퀘스트의 이름")]
    public string QuestName;
    [Header("퀘스트의 최소레벨")]
    public int QuestRequiredLevel;
    [Header("퀘스트를 주는 NPC의 id (int)")]
    public int QuestNPC;
    [Header("선행 퀘스트의 id들의 리스트")]
    public List<int> QuestPrerequisites;
}
