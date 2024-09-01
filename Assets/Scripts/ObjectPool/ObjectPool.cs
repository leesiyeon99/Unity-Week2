using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] int size;

    [SerializeField] private List<GameObject> pool;

    private void Awake()
    {
        CreatePool();
    }

    private void CreatePool()
    {
        pool = new List<GameObject>(size);
        for (int i = 0; i < size; i++)
        {
            GameObject instance = Instantiate(prefab);
            instance.transform.parent = transform;
            instance.SetActive(false);
            pool.Add(instance);
        }
    }

    public GameObject GetPool(Vector3 position, Quaternion rotation)
    {
        if (pool.Count > 0)
        {
            GameObject instance = pool[pool.Count - 1]; 
            pool.RemoveAt(pool.Count - 1);

            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.SetActive(true);

            return instance;
        }

        return null;
    }

    public void ReturnPool(GameObject instance)
    {
        instance.SetActive(false);
        pool.Add(instance);
    }
}
