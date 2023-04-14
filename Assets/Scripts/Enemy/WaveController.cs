using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] enemySpawner[] spawners;
    [SerializeField] int[] intervals;

    private int _index;
    private bool _playing;
    private float _timer;

    void Start()
    {
        _index = 0;
        _timer = 0;
        _playing = false;
        StartGame();
    }
    public void StartGame()
    {
        _playing = true;
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if ( _playing && _timer > intervals[_index] && _index < spawners.Length)
        {
            Debug.Log($"Spawning {spawners[_index].spawnCount} enemies with a delay of {intervals[_index]}");
            spawners[_index].SpawnEnemies();
            _index += 1;
            _timer = 0;
        }
    }
}
