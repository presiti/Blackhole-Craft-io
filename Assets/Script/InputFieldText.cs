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
        //키보드
        if (playerInput.text.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }

    //마우스
    public string InputName()
    {
        PlayerPrefs.SetString("CurrentPlayerName", playerInput.text);
        //        GameManager.instance.ScoreSet(GameManager.instance.score, playerName);    // 랭킹 계산 + 결과창

        return playerInput.text;
    }
}
