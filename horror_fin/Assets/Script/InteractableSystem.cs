using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s
{
    /// <summary>
    /// 互動系統:偵測玩家是否進入且執行互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";

        private void OnTriggerEnter(Collider other)
        {
             
        }
    }
}