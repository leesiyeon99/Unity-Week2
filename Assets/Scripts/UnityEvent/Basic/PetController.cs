using System.Collections;
using UnityEngine;

public class PetController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveStopDistance;
    private Coroutine moveCoroutine;

    //��ũ��Ʈ�� ����Ƽ �̺�Ʈ ����ϴ� ���----------------------------------------
    private void Awake()
    {
        Init();
    }
    private void OnDestroy() //���� Pet�� ������� �̺�Ʈ�� ����س��ұ� ������ �޸𸮴��� �߻��� �� ����=>��ü�� �ı��� �� ��ϰ��踦 �������������
    {
        playerController.OnPetCalled.RemoveListener(MoveToPlayer);
    }
    private void Init()
    {
        playerController.OnPetCalled.AddListener(MoveToPlayer);
    }
    //----------------------------------------------------------------------------



    public void MoveToPlayer()
    {
        if (moveCoroutine == null)
        {
            moveCoroutine = StartCoroutine(MoveToTarget(playerController.transform));
        }
    }
    private IEnumerator MoveToTarget(Transform target)
    {
        while (true)
        {
            float distance = Vector3.Distance(
                target.transform.position,
                transform.position
                );

            if (distance <= moveStopDistance)
            {
                moveCoroutine = null;
                yield break;
            }

            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
