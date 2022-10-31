using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private CellManager cellManager;

    public float score = 0.0f;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObject = collision.gameObject;
        if (gameObject.CompareTag("Experience"))
        {
            // ���� ���� ���ֱ�
            cellManager.DestoryCell(gameObject);

            // ���� �ø���
            score += 5;
            scoreText.text = ((int)score).ToString();
        }

        if (gameObject.CompareTag("whitehole")) {

            Destroy(gameObject);    // ���� ȭ��ƮȦ ���ֱ�

            // ���� ���
            score -= score * 0.3f;
            scoreText.text = ((int)score).ToString();
        }
    }
}
