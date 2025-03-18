using System.Collections;
using UnityEngine;

public class FallAfterDelay : MonoBehaviour
{
    // 倒れるまでの遅延時間（秒）
    public float delay = 3.0f;

    // 倒れる角度
    public Vector3 fallRotation = new Vector3(90, 0, 0);

    // 倒れる速度
    public float fallSpeed = 2.0f;

    // 倒れる最終位置
    public Vector3 fallPosition;

    // 位置移動速度
    public float moveSpeed = 2.0f;

    private bool shouldFall = false;
    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private Vector3 initialPosition;

    void Start()
    {
        // 初期回転と位置を保存
        initialRotation = transform.rotation;
        targetRotation = Quaternion.Euler(fallRotation) * initialRotation;
        initialPosition = transform.position;

        // 遅延時間後に倒れ始める
        StartCoroutine(StartFallAfterDelay());
    }

    IEnumerator StartFallAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        shouldFall = true;
    }

    void Update()
    {
        if (shouldFall)
        {
            // スムーズに倒れる
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * fallSpeed);
            transform.position = Vector3.Lerp(transform.position, fallPosition, Time.deltaTime * moveSpeed);

            // 回転と位置が目標値にほぼ達したら停止
            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f && Vector3.Distance(transform.position, fallPosition) < 0.1f)
            {
                shouldFall = false;
            }
        }
    }
}
