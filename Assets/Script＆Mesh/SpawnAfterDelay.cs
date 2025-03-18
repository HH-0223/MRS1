using System.Collections;
using UnityEngine;

public class SpawnAfterDelay : MonoBehaviour
{
    // 出現させるオブジェクトのPrefab
    public GameObject objectToSpawn;

    // 出現させる位置
    public Transform spawnPosition;

    // 出現までの遅延時間（秒）
    public float delay = 2.0f;

    void Start()
    {
        // 指定された遅延時間後にオブジェクトを出現させる
        StartCoroutine(SpawnObjectAfterDelay());
    }

    IEnumerator SpawnObjectAfterDelay()
    {
        // 指定秒数待機
        yield return new WaitForSeconds(delay);

        // オブジェクトを出現させる
        if (objectToSpawn != null && spawnPosition != null)
        {
            Instantiate(objectToSpawn, spawnPosition.position, spawnPosition.rotation);
        }
        else
        {
            Debug.LogError("objectToSpawn または spawnPosition が設定されていません。");
        }
    }
}