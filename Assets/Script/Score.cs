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
            // 먹은 세포 없애기
            cellManager.DestoryCell(gameObject);

            // 점수 올리기
            score += 5;
            scoreText.text = ((int)score).ToString();
        }

        if (gameObject.CompareTag("whitehole")) {

            Destroy(gameObject);    // 닿은 화이트홀 없애기

            // 점수 깍기
            score -= score * 0.3f;
            scoreText.text = ((int)score).ToString();
        }
    }
}
