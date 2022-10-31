using UnityEngine;

public class ColorHtmlPropertyAttribute : PropertyAttribute
{
}

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    [ColorHtmlProperty]
    private Color[] colorList;

    SpriteRenderer cell;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ColorUtility.ToHtmlStringRGBA(new Color(255, 234, 123, 255)));
        cell = GetComponent<SpriteRenderer>();
        Change();
    }

    private void Change()
    {
        cell.color = colorList[Random.Range(0, colorList.Length)];
    }
}
