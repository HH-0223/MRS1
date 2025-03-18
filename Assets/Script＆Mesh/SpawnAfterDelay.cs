using System.Collections;
using UnityEngine;

public class SpawnAfterDelay : MonoBehaviour
{
    // �o��������I�u�W�F�N�g��Prefab
    public GameObject objectToSpawn;

    // �o��������ʒu
    public Transform spawnPosition;

    // �o���܂ł̒x�����ԁi�b�j
    public float delay = 2.0f;

    void Start()
    {
        // �w�肳�ꂽ�x�����Ԍ�ɃI�u�W�F�N�g���o��������
        StartCoroutine(SpawnObjectAfterDelay());
    }

    IEnumerator SpawnObjectAfterDelay()
    {
        // �w��b���ҋ@
        yield return new WaitForSeconds(delay);

        // �I�u�W�F�N�g���o��������
        if (objectToSpawn != null && spawnPosition != null)
        {
            Instantiate(objectToSpawn, spawnPosition.position, spawnPosition.rotation);
        }
        else
        {
            Debug.LogError("objectToSpawn �܂��� spawnPosition ���ݒ肳��Ă��܂���B");
        }
    }
}