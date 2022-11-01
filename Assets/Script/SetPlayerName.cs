using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetPlayerName : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nameText;

    StartButton startBtn = new StartButton();

    InputFieldText inputText = new InputFieldText();

    // Start is called before the first frame update
    void Start()
    {
        if (startBtn.OnClickStart()){
            nameText.text = inputText.InputName();
        }
        
    }
}
