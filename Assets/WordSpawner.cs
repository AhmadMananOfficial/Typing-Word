using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
	public GameObject wordprefab;
	public Transform canvas;
	
	public float minSpawnX = -2.5f;
	public float maxSpawnX = 2.5f;
	public float spawnY = 7;
    
	public WordDisplayer SpawnWord()
	{
		Vector3 randomPosition = new Vector3(Random.Range(minSpawnX, maxSpawnX), spawnY, 0);
    	
		GameObject wordObj = Instantiate(wordprefab, randomPosition, Quaternion.identity, canvas);
	    WordDisplayer wordDisplayer = wordObj.GetComponent<WordDisplayer>();
	    
	    return wordDisplayer;
    }
}
