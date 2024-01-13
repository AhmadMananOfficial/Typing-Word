using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
	public WordManager wordManager;
	
	public float wordDelayTime = 1.5f;
	public float nextWordTime = 0f;
	
	
    void Update()
    {
	    if(Time.time >= nextWordTime)
	    {
	    	wordManager.AddWord();
	    	nextWordTime = Time.time + wordDelayTime;
	    	wordDelayTime *= .99f;
	    }
    }
}
