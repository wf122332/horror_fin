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

        death = GameObject.Find("���`�e��").GetComponent<Canvas>();
        textTitle = GameObject.Find("���h���D").GetComponent<TextMeshProUGUI>();
    }
}
