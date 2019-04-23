using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
	public Transform enemyPrefab;
	public Transform spawnPoint;
	
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;
	public Text waveCountDownText;
	
	private int wavenumber = 0;
	

    // Update is called once per frame
    void Update()
    {
    
		if(countdown <=0f) {
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}
		countdown -= Time.deltaTime;
		waveCountDownText.text = Mathf.Round(countdown).ToString();
		
		
    }
	IEnumerator SpawnWave() { //A coroutine in 
	//From Collections
		wavenumber++;
	//	 Debug.Log("Wave Incomming");
		for(int i=0;i<wavenumber;i++) {
			SpawnEnemy();
			yield return new WaitForSeconds(0.5f);
			
		}
		
		
	}
	void SpawnEnemy() {
		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
		
	}
}
