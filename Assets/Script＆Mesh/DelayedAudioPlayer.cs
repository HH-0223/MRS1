using UnityEngine;

public class DelayedAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource; // 再生するAudioSource
    public float delay = 1.0f;      // 再生を遅らせる時間（秒）

    private void Start()
    {
        if (audioSource == null)
        {
            Debug.LogError("AudioSourceが設定されていません。");
            return;
        }

        // 遅延再生を開始
        StartCoroutine(PlayAudioWithDelay());
    }

    private System.Collections.IEnumerator PlayAudioWithDelay()
    {
        // 指定した秒数待機
        yield return new WaitForSeconds(delay);

        // AudioSourceを再生
        audioSource.Play();
    }
}
