using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    public GameObject targetObject; // �T�C�Y��ύX����I�u�W�F�N�g
    private Vector3 originalScale; // ���̃T�C�Y��ۑ�
    private int scaleStep = 0; // ���݂̃T�C�Y�̒i�K
    private int maxSteps = 5; // �ő�̒i�K��
    private float scaleFactor = 0.2f; // 1�i�K���Ƃ̃T�C�Y�ύX��

    void Start()
    {
        // �I�u�W�F�N�g�̌��̃T�C�Y��ۑ�
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