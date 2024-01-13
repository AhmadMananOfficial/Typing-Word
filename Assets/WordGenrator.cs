using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenrator : MonoBehaviour
{
	public static string[] randomWords = {
	"apple", "book", "chair", "dog", "elephant", "fish", "giraffe", "house", "ice", "juice",
  "kite", "lion", "milk", "nest", "orange", "panda", "queen", "rain", "sun", "tree",
  "umbrella", "van", "water", "xylophone", "yak", "zebra", "yellow", "window", "wind",
  "wheel", "watch", "wall", "walk", "wagon", "violin", "vegetable", "vacation", "turtle",
  "truck", "train", "treehouse", "treasure", "triangle", "toothbrush", "toaster", "tiger",
  "table", "swing", "slide", "sky", "skateboard", "school", "rainbow", "puzzle", "princess",
  "prince", "piano", "ocean", "octopus", "nurse", "night", "moon", "monkey", "milkshake",
  "mirror", "microphone", "magic", "king", "knight", "jump", "jacket", "island", "ice cream",
  "hospital", "helicopter", "guitar", "frog", "flower", "firefighter", "farmer", "elephant",
  "drum", "dinosaur", "doctor", "dolphin", "desert", "cowboy", "computer", "castle", "camera",
  "butterfly", "brush", "breakfast", "bridge", "balloon", "baby", "airplane", "alphabet",
  "alligator", "artist", "athlete", "author", "baker", "basketball", "beach", "bear", "bicycle",
  "bird", "birthday", "blanket", "boat", "boots", "bowl", "box", "bracelet", "brain", "bread",
  "bridge", "broccoli", "brush", "bubble", "bucket", "bug", "bunny", "bus", "button", "Ahmad"
	};
	
	
	public static string GetRandom()
	{
		int randomIndex = Random.Range(0, randomWords.Length);
		string randomWord = randomWords[randomIndex];
		
		return randomWord;
	}

	
}
