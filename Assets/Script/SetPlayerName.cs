using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetPlayerName : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nameText;

    InputFieldText inputText = new InputFieldText();

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            nameText.text = inputText.InputName();
        }
        
    }
}
