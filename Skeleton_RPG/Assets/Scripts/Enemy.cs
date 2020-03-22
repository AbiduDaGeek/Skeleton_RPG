using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{
	PlayerManager playerManager;
	CharacterStats thisStats;
	void Start()
	{
		playerManager = PlayerManager.instance;
		thisStats = GetComponent<CharacterStats>();
	}
	public override void Interact()
	{
		base.Interact();
		//Attac the enemy
		CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterCombat>();
		if (playerCombat != null)
		{
			playerCombat.Attack(thisStats);
		}
	}
}
