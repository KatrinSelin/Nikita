using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {

	// Use this for initialization
	public override void OnSetUpDialogue() {

		Speech.AddDialogue("0", "Welcome to our planet!", "1");



		Speech.AddDialogue("1", "Yauuuu, fack you!", "2");
		Speech.AddDialogue("2", "Ты не можешь перейти на 2 левел потому, что не собрал чертовы монеты))))Собери чертовы монеты а также способность и сможешь перейти на лвл 2");

	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");

	}
}