﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour {

    public Player player;
    public GameController controller;
    public float critDamageMultiplier = 1.5f;

    public enum CombatState
    {
        OutOfCombat, PlayersTurn, MonstersTurn, PlayerDead
    }

    CombatState combatState = CombatState.OutOfCombat;

    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<Player>();
        controller = GetComponent<GameController>();        
	}
	
	// Update is called once per frame
	void Update ()
    {
        IsPlayerDead();
    }

    private Monsters GetMonsterPlayerAttacked(string mobAttacked)
    {
        for (int i = 0; i < controller.mobsInTheRoom.Count; i++)
        {
            if (mobAttacked == controller.mobsInTheRoom[i].monsterKeyword)
            {
                return controller.mobsInTheRoom[i];
            }
            else
            {
                return null;
            }
        }
        return null;
    }

    // Attack formula for both players and monsters is atk / (atk + def) where both atk's are attackers attack and def is defenders defense
    // This should scale pretty decent and will almost never result in a 100% chance to hit

    private void PlayerAttack(string mobAttacked)
    {
        combatState = CombatState.PlayersTurn;
        var toHit = player.PlayerAttack / (player.PlayerAttack + GetMonsterPlayerAttacked(mobAttacked).monsterDefense);
        // random roll to see if hit is made
        var rollToHit = Random.Range(1, 100);
        if(rollToHit < toHit)
        {
            // hit successful
            bool playerCrit = CalculatePlayerCrit();
            float totalDamageDone = CalculatePlayerDamage(playerCrit);
        }
        else
        {
            // missed
        }
    }

    private float CalculatePlayerDamage(bool playerCrit)
    {
        if (playerCrit)
        {
            // Calculate damage and multiply it by critDamageModifier
            var damageDealt = 1 * critDamageMultiplier; // TODO set up damage formula
            return damageDealt;
        }
        else
        {
            // Calculate Damage normally
            var damageDealt = 1; // TODO set up damage formula
            return damageDealt;
        }
    }

    private bool CalculatePlayerCrit()
    {
        // TODO set up crit formula        
        return false;
    }

    private void MonstersAttack()
    {
        combatState = CombatState.MonstersTurn;
        
    }

    private void CalculateMonstersDamage()
    {

    }

    private void CalculateMonstersCrit()
    {

    }

    private void GetLootDrops()
    {

    }

    private bool IsPlayerDead()
    {
        if (player.PlayerCurrentHealth <= 0)
        {
            combatState = CombatState.PlayerDead;
            return true;
        }
        else
        {
            return false;
        }
    }
}