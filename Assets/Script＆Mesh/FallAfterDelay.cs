using System.Collections;
using UnityEngine;

public class FallAfterDelay : MonoBehaviour
{
    // �|���܂ł̒x�����ԁi�b�j
    public float delay = 3.0f;

    // �|���p�x
    public Vector3 fallRotation = new Vector3(90, 0, 0);

    // �|��鑬�x
    public float fallSpeed = 2.0f;

    // �|���ŏI�ʒu
    public Vector3 fallPosition;

    // �ʒu�ړ����x
    public float moveSpeed = 2.0f;

    private bool shouldFall = false;
    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private Vector3 initialPosition;

    void Start()
    {
        // ������]�ƈʒu��ۑ�
        initialRotation = transform.rotation;
        targetRotation = Quaternion.Euler(fallRotation) * initialRotation;
        initialPosition = transform.position;

        // �x�����Ԍ�ɓ|��n�߂�
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
            // �X���[�Y�ɓ|���
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * fallSpeed);
            transform.position = Vector3.Lerp(transform.position, fallPosition, Time.deltaTime * moveSpeed);

            // ��]�ƈʒu���ڕW�l�ɂقڒB�������~
            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f && Vector3.Distance(transform.position, fallPosition) < 0.1f)
            {
                shouldFall = false;
            }
        }
    }
}
