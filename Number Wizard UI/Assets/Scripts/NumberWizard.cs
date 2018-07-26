using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed = 10;
	
	public Text text;
	
	
	void Start () {
		StartGame ();
		
		
	}
	void StartGame () {
		max = 1001;
		min = 1;
		maxGuessesAllowed = 10;
		NextGuess ();



	}
		
		
		
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess () {
		guess =  Random.Range(min,max+1);
		text.text = guess.ToString ();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if(maxGuessesAllowed < 0){
		Application.LoadLevel("Win");
		
		}	
	}
}
