using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private GameObject[] _levels;

    private float _num;
    private Camera _camera;
    private GameObject _initialPrefab;
    private GameObject _currentPrefab;
    private GameObject _prevPrefab;
    private float _spawnOffset = 10f;
    private float _offsetStep = 10f;
    private Vector3 _spawnPosition;

    private void Start()
    {
        _camera = Camera.main;
        Vector3 _initialSpawnPosition1 = new Vector3(0, 0);
        _initialPrefab = Instantiate(_levels[Random.Range(0,10)], _initialSpawnPosition1, Quaternion.identity);
        Vector3 _initialSpawnPosition2 = new Vector3(0, 10);
        _currentPrefab = Instantiate(_levels[Random.Range(10,38)], _initialSpawnPosition2, Quaternion.identity);
    }
    private void Update()
    {
        if (_camera.transform.position.y >= _spawnOffset)
        {
            SpawnPref();
        }
    }

    private void SpawnPref()
    {
        if (_initialPrefab != null)
        {
            Destroy(_initialPrefab.gameObject);
        }
        if (_prevPrefab != null)
        {
            Destroy(_prevPrefab.gameObject);
        }
        _prevPrefab = _currentPrefab;
        _spawnOffset += _offsetStep;
        _spawnPosition = new Vector3(0.0f, _spawnOffset);
        _currentPrefab = Instantiate(_levels[Random.Range(10, 38)], _spawnPosition, Quaternion.identity);
    }
}