using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInterface : MonoBehaviour
{

    [SerializeField] Storage storage;

    [SerializeField] TextMeshProUGUI food;
    [SerializeField] TextMeshProUGUI gold;
    [SerializeField] TextMeshProUGUI tools;
    [SerializeField] TextMeshProUGUI iron;
    [SerializeField] TextMeshProUGUI wood;

    // Update is called once per frame
    void Update()
    {
        food.SetText(storage.GetFood().ToString());
        gold.SetText(storage.GetGold().ToString());
        tools.SetText(storage.GetTools().ToString());
        iron.SetText(storage.GetIron().ToString());
        wood.SetText(storage.GetWood().ToString());
    }
}
