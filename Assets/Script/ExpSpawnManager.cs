using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpSpawnManager : MonoBehaviour
{
    public CellManager cellManager;

    private int cnt = CellManager.initCount; //������ ����(���� ������Ʈ)�� ����
    private BoxCollider2D area;     //BoxCollider2D�� ����� �������� ���� ����
    private List<GameObject> ExpList = new List<GameObject>();		//������ ���� ������Ʈ ����Ʈ


    Color color;
    SpriteRenderer cell;
    private string[] colorList = new string[] { "ffafb0", "ffafd8", "eeb7b4", "f2cfa5", "fcffb0", "aee4ff", "b5c7ed", "c4f4fe", 
        "bee9b4", "fdfa87", "fcc6f7", "caa6fe", "ffafd8", "afffba", "e2ffaf", "fcffb0", "f2cfa5", "ffe4af", "dfd4e4", "a9e1ed",
        "99ffcc", "99ffff"};

    void Start()
    {
        area = GetComponent<BoxCollider2D>();
        StartCoroutine("Spawn", 1);
    }

    //���� ������Ʈ�� �����Ͽ� scene�� �߰�
    private IEnumerator Spawn(float delayTime)
    {
        for (int i = 0; i < cnt; i++) //count��ŭ å ����
        {
            Vector3 spawnPos = GetRandomPosition(); //���� ��ġ return

            //����, ��ġ, ȸ������ �Ű������� �޾� ������Ʈ ����
            GameObject instance = cellManager.Create(spawnPos);

            ColorUtility.TryParseHtmlString(colorList[Random.Range(1, 3)], out color);
            cell.color = color;

            ExpList.Add(instance); //������Ʈ ������ ���� ����Ʈ�� add
        }
        area.enabled = false;
        yield return new WaitForSeconds(delayTime);   //�ֱ� : 3��

        if (cellManager.Count < cnt) //������ ���� �پ����� ��
        {
            StartCoroutine("Spawn", 1); //���� �ٽ� ����
        }

    }

    //BoxCollider2D ���� ������ ��ġ�� return
    private Vector2 GetRandomPosition()
    {
        Vector2 basePosition = transform.position;  //������Ʈ�� ��ġ
        Vector2 size = area.size;                   //box colider2d, �� ���� ũ�� ����

        //x, y�� ���� ��ǥ ���
        float posX = basePosition.x + Random.Range(-size.x / 2f, size.x / 2f);
        float posY = basePosition.y + Random.Range(-size.y / 2f, size.y / 2f);

        Vector2 spawnPos = new Vector2(posX, posY);

        return spawnPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
