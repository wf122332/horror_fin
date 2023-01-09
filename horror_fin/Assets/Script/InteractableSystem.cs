using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace s
{
    /// <summary>
    /// 互動系統:偵測玩家是否進入且執行互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;

        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField, Header("啟動後的對話資料")]
        private DialogueData dataDialogueActive;
        [SerializeField, Header("啟動後對話結束後的事件")]
        private UnityEvent onDialogueFinishAfterActive;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        

        private void Awake()
        {
            dialogueSystem = GameObject.Find("對話畫布").GetComponent<DialogueSystem>();
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
        /// 隱藏物件
        /// </summary>
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }

    }
}