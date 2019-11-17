using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Storage : MonoBehaviour{

    [SerializeField] TextMeshProUGUI woodText;
    [SerializeField] TextMeshProUGUI ironText;
    [SerializeField] TextMeshProUGUI foodText;
    [SerializeField] TextMeshProUGUI toolText;
    [SerializeField] TextMeshProUGUI goldText;

    int woodResource = 0;
    int ïronResource = 0;
    int foodResource = 0;
    int toolResource = 0;
    int goldResource = 0;

    void Start() {
        
    }

    void Update() {
        woodText.text = woodResource.ToString();
        woodText.text = woodResource.ToString();
        woodText.text = woodResource.ToString();
        woodText.text = woodResource.ToString();
        woodText.text = woodResource.ToString();
    }
}
