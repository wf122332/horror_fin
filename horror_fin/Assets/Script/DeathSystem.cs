using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathSystem : MonoBehaviour
{
    public static DeathSystem instance;
    private Canvas death;
    private TextMeshProUGUI textTitle;

    private void Awake()
    {
        instance = this;

        death = GameObject.Find("死亡畫布").GetComponent<Canvas>();
        textTitle = GameObject.Find("結柳標題").GetComponent<TextMeshProUGUI>();
    }
}
