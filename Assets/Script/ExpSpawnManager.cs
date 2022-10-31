using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ExpSpawnManager : MonoBehaviour
{
    public CellManager cellManager;

    private int cnt = CellManager.initCount; //������ ����(���� ������Ʈ)�� ����
    private BoxCollider2D area;     //BoxCollider2D�� ����� �������� ���� ����
    private List<GameObject> ExpList = new List<GameObject>();		//������ ���� ������Ʈ ����Ʈ


    void Start()
    {
        area = GetComponent<BoxCollider2D>();
        StartCoroutine("Spawn", 3);
    }

    //���� ������Ʈ�� �����Ͽ� scene�� �߰�
    private IEnumerator Spawn(float delayTime)
    {
        while (true)
        {
            for (int i = 0; i < cnt; i++) //count��ŭ å ����
            {
                Vector3 spawnPos = GetRandomPosition(); //���� ��ġ return

                //����, ��ġ, ȸ������ �Ű������� �޾� ������Ʈ ����
                GameObject instance = cellManager.Create(spawnPos);
                if (instance == null)
                {
                    break;
                }

                ExpList.Add(instance); //������Ʈ ������ ���� ����Ʈ�� add
            }

            area.enabled = false;
            cnt = CellManager.initCount / 10;

            yield return new WaitForSeconds(delayTime);   //�ֱ� : 3��
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
