using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    public GameObject targetObject; // サイズを変更するオブジェクト
    private Vector3 originalScale; // 元のサイズを保存
    private int scaleStep = 0; // 現在のサイズの段階
    private int maxSteps = 5; // 最大の段階数
    private float scaleFactor = 0.2f; // 1段階ごとのサイズ変更量

    void Start()
    {
        // オブジェクトの元のサイズを保存
        originalScale = targetObject.transform.localScale;
    }

    public void ScaleUp()
    {
        if (scaleStep < maxSteps)
        {
            scaleStep++;
            targetObject.transform.localScale = originalScale * (1 + scaleStep * scaleFactor);
        }
    }

    public void ScaleDown()
    {
        if (scaleStep > 0)
        {
            scaleStep--;
            targetObject.transform.localScale = originalScale * (1 + scaleStep * scaleFactor);
        }
    }
}