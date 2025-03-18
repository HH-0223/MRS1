using UnityEngine;

public class DelayedAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource; // �Đ�����AudioSource
    public float delay = 1.0f;      // �Đ���x�点�鎞�ԁi�b�j

    private void Start()
    {
        if (audioSource == null)
        {
            Debug.LogError("AudioSource���ݒ肳��Ă��܂���B");
            return;
        }

        // �x���Đ����J�n
        StartCoroutine(PlayAudioWithDelay());
    }

    private System.Collections.IEnumerator PlayAudioWithDelay()
    {
        // �w�肵���b���ҋ@
        yield return new WaitForSeconds(delay);

        // AudioSource���Đ�
        audioSource.Play();
    }
}
