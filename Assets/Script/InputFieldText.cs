using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldText : MonoBehaviour
{
    public TextMeshProUGUI playerInput;


    private void Update()
    {
        //Ű����
        if (playerInput.text.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }

    //���콺
    public string InputName()
    {
        PlayerPrefs.SetString("CurrentPlayerName", playerInput.text);
        //        GameManager.instance.ScoreSet(GameManager.instance.score, playerName);    // ��ŷ ��� + ���â

        return playerInput.text;
    }
}
