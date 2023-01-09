using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace s
{
    /// <summary>
    /// ���ʨt��:�������a�O�_�i�J�B���椬�ʦ欰
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܸ��")]
        private DialogueData dataDialogue;
        [SerializeField, Header("��ܵ����᪺�ƥ�")]
        private UnityEvent onDialogueFinish;

        [SerializeField, Header("�ҰʹD��")]
        private GameObject propActive;
        [SerializeField, Header("�Ұʫ᪺��ܸ��")]
        private DialogueData dataDialogueActive;
        [SerializeField, Header("�Ұʫ��ܵ����᪺�ƥ�")]
        private UnityEvent onDialogueFinishAfterActive;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        

        private void Awake()
        {
            dialogueSystem = GameObject.Find("��ܵe��").GetComponent<DialogueSystem>();
        }

        private void OnTriggerEnter(Collider other)
        {
             if(other.name.Contains(nameTarget))
            {
                if(propActive==null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive,onDialogueFinishAfterActive);     
                }
                
            }
        }

        /// <summary>
        /// ���ê���
        /// </summary>
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }

    }
}