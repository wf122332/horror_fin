using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s
{
    /// <summary>
    /// ���ʨt��:�������a�O�_�i�J�B���椬�ʦ欰
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܸ��")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";

        private void OnTriggerEnter(Collider other)
        {
             
        }
    }
}