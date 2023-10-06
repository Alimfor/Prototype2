using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 _spawnPos = new Vector3(25, 0, 0);
    [SerializeField] private float timeSpawn;
    private float _timer;
    void Update()
    {
        if (_timer <= 0)
        {
            SpawnDanger();
            _timer += timeSpawn;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }

    private void SpawnDanger()
    {
        var i = Random.Range(0,obstaclePrefab.Length);
        var obj = obstaclePrefab[i];
        _spawnPos = new Vector3(25, 5, 0);
        Instantiate(obj, _spawnPos, Quaternion.identity,transform);
    }
}
