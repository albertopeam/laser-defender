using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] List<WaveConfig> waveConfigs;
    int startingWave = 0;

    // Start is called before the first frame update
    void Start()
    {
        var currentWave = waveConfigs[startingWave];
        StartCoroutine(SpawnAllEnenemiesInWave(currentWave));
    }

    private IEnumerator SpawnAllEnenemiesInWave(WaveConfig waveConfig)
    {
        for(int enemyCount = 0; enemyCount < waveConfig.GetNumberOfEnemies(); enemyCount++)
        {
            Vector3 initialPosition = waveConfig.GetWaypoints()[0].transform.position;
            Instantiate(waveConfig.GetEnemyPrefab(), initialPosition, Quaternion.identity);
            yield return new WaitForSeconds(waveConfig.GetTimeBetweenSpwans());
        }
    }
}
