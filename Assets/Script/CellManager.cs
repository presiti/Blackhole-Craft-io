using UnityEngine;

public class CellManager : MonoBehaviour
{
    public static int initCount = 100;

    public GameObject ExpCell;
    public int limitCount = 5000;
    private int count;

    public int Count { get { return count; } }

    public GameObject Create(Vector3 spawnPos)
    {
        count++;
        if (count > limitCount)
        {
            return null;
        }

        return Instantiate(ExpCell, spawnPos, Quaternion.identity);
    }

    public void DestoryCell(GameObject obj)
    {
        --count;
        Destroy(obj);
    }
}
