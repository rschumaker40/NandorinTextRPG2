﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Dictionary<string, string> inventory = new Dictionary<string, string>();
    public Dictionary<string, string> keyRing = new Dictionary<string, string>();
    public Dictionary<string, string> potions = new Dictionary<string, string>();    

    [SerializeField] string playerName;
    [SerializeField] string playerRace;
    [SerializeField] string playerClass;
    [SerializeField] string playerCurrentRoom;
    [SerializeField] int playerLevel;
    [SerializeField] int playerStrength;
    [SerializeField] int playerAgility;
    [SerializeField] int playerEndurance;
    [SerializeField] int playerMagic;
    [SerializeField] float playerAttack;
    [SerializeField] float playerDefense;
    [SerializeField] float playerCurrentHealth;
    [SerializeField] float playerMaxHealth;
    [SerializeField] float playerCurrentMana;
    [SerializeField] float playerMaxMana;
    [SerializeField] int playerCurrentExperience;
    [SerializeField] int playerGold;
    [SerializeField] Room currentRoom;

    private RoomNavigation roomnav;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public string PlayerRace
    {
        get { return playerRace; }
        set { playerRace = value; }
    }

    public string PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public int PlayerStrength
    {
        get { return playerStrength; }
        set { playerStrength = value; }
    }

    public int PlayerAgility
    {
        get { return playerAgility; }
        set { playerAgility = value; }
    }

    public int PlayerEndurance
    {
        get { return playerEndurance; }
        set { playerEndurance = value; }
    }

    public int PlayerMagic
    {
        get { return playerMagic; }
        set { playerMagic = value; }
    }

    public float PlayerAttack
    {
        get { return playerAttack; }
        set { playerAttack = value; }
    }

    public float PlayerDefense
    {
        get { return playerDefense; }
        set { playerDefense = value; }
    }

    public float PlayerCurrentHealth
    {
        get { return playerCurrentHealth; }
        set { playerCurrentHealth = value; }
    }

    public float PlayerMaxHealth
    {
        get { return playerMaxHealth; }
        set { playerMaxHealth = value; }
    }

    public float PlayerCurrentMana
    {
        get { return playerCurrentMana; }
        set { playerCurrentMana = value; }
    }

    public float PlayerMaxMana
    {
        get { return playerMaxMana; }
        set { playerMaxMana = value; }
    }

    public int PlayerCurrentExperience
    {
        get { return playerCurrentExperience; }
        set { playerCurrentExperience = value; }
    }

    public int PlayerGold
    {
        get { return playerGold; }
        set { playerGold = value; }
    }

    public string PlayerCurrentRoom
    {
        get { return playerCurrentRoom; }
        set { playerCurrentRoom = value; }
    }

    public Room CurrentRoom
    {
        get { return currentRoom; }
        set { currentRoom = value; }
    }

    void Awake()
    {

    }

    private void Start () {
        DontDestroyOnLoad(this);        
	}
	
	private void Update () {
		
	}
}
