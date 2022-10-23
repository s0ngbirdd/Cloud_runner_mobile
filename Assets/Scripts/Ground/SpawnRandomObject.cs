using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObject : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private List<GameObject> _gameObjects;
    [SerializeField] private GameObject _parent;

    private void Start()
    {
        InstantiateRandomObject();
    }

    private void InstantiateRandomObject()
    {
        int index = Random.Range(0, _gameObjects.Count);
        GameObject obj = Instantiate(_gameObjects[index], transform.position, Quaternion.identity);
        obj.transform.SetParent(_parent.transform, true);
    }
}
