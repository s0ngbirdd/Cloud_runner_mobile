using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private GameObject _groundTile;
    [SerializeField] private GameObject _groundFinishTile;
    [SerializeField] private int _numberToSpawn = 7;

    // Private fields
    private Vector3 _nextSpawnPoint;

    // Spawn fixed number of tiles + finish tile
    private void Start()
    {
        for (int i = 0; i < _numberToSpawn; i++)
        {
            SpawnTile();
        }
        SpawnFinishTile();
    }

    public void SpawnTile()
    {
        GameObject temp = Instantiate(_groundTile, _nextSpawnPoint, Quaternion.identity);
        _nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnFinishTile()
    {
        Instantiate(_groundFinishTile, _nextSpawnPoint, Quaternion.identity);
    }
}
