using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s
{
    /// <summary>
    /// ��ܸ��
    /// </summary>
    [CreateAssetMenu(menuName ="s/Dialogue Data",fileName ="new Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("��ܪ̦W��")]
        public string dialogueName; 
        [Header("��ܪ̤��e"),TextArea(2,10)]
        public string[] dialogueContents;
    }
}