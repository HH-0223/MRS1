using UnityEngine;

public class DeleteObjectOnTrigger : MonoBehaviour
{
    // �폜�Ώۂ̃I�u�W�F�N�g
    public GameObject targetObject;

    // �Đ����鉹�̃N���b�v
    public AudioClip triggerSound;

    // AudioSource �R���|�[�l���g
    private AudioSource audioSource;

    void Start()
    {
        // AudioSource �R���|�[�l���g���擾�܂��͒ǉ�
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // �E�l�����w�g���K�[�������ꂽ�Ƃ�
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("�E�l�����w�g���K�[��������");

            // �����Đ�
            if (triggerSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(triggerSound);
                Debug.Log("�����Đ����܂���");
            }
            else
            {
                Debug.LogWarning("�����N���b�v�܂���AudioSource���ݒ肳��Ă��܂���");
            }

            // �폜�Ώۂ̃I�u�W�F�N�g���ݒ肳��Ă���ꍇ
            if (targetObject != null)
            {
                Destroy(targetObject);
                Debug.Log("�I�u�W�F�N�g���폜���܂���");
            }
            else
            {
                Debug.LogWarning("�폜�Ώۂ̃I�u�W�F�N�g���ݒ肳��Ă��܂���");
            }
        }
    }
}
