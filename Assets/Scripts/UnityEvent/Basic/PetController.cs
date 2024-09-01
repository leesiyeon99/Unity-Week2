using System.Collections;
using UnityEngine;

public class PetController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveStopDistance;
    private Coroutine moveCoroutine;

    //스크립트로 유니티 이벤트 사용하는 방법----------------------------------------
    private void Awake()
    {
        Init();
    }
    private void OnDestroy() //만약 Pet이 사라져도 이벤트에 등록해놓았기 때문에 메모리누수 발생할 수 있음=>객체가 파괴될 때 등록관계를 삭제시켜줘야함
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
