﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
	public List<Word> words;
	
	public bool hasActiveWord;
	[Tooltip("To store the active Word")]
	public Word activeWord;
   
	public WordSpawner wordSpawner;
     
    
	public void AddWord()
	{
		Word word = new Word(WordGenrator.GetRandom(), wordSpawner.SpawnWord()); 
		Debug.Log(word.word);
		
		words.Add(word);
	}
	
	public void TypeLetter(char letter)
	{
		if(hasActiveWord)
		{
			if(activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		}
		else
		{
			foreach(Word word in words)
			{
				if(word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}
		if(hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
		}
		
	}
	
}
