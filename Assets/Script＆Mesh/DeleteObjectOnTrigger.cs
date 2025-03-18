using UnityEngine;

public class DeleteObjectOnTrigger : MonoBehaviour
{
    // 削除対象のオブジェクト
    public GameObject targetObject;

    // 再生する音のクリップ
    public AudioClip triggerSound;

    // AudioSource コンポーネント
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource コンポーネントを取得または追加
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // 右人差し指トリガーが押されたとき
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("右人差し指トリガーを押した");

            // 音を再生
            if (triggerSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(triggerSound);
                Debug.Log("音を再生しました");
            }
            else
            {
                Debug.LogWarning("音声クリップまたはAudioSourceが設定されていません");
            }

            // 削除対象のオブジェクトが設定されている場合
            if (targetObject != null)
            {
                Destroy(targetObject);
                Debug.Log("オブジェクトを削除しました");
            }
            else
            {
                Debug.LogWarning("削除対象のオブジェクトが設定されていません");
            }
        }
    }
}
