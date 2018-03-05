﻿using System.Collections.Generic;
using UnityEngine;

public class RoomNavigation : MonoBehaviour
{

    public Room currentRoom;
    public Player player;
    [HideInInspector] public Dictionary<string, Room> exitDictionary = new Dictionary<string, Room>();
    [HideInInspector] public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();

    private GameController controller;
    
    private void Awake()
    {
        controller = GetComponent<GameController>();
    }

    private void Start()
    {
        currentRoom = player.CurrentRoom;
    }

    public void UnpackExitsInRoom()
    {
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            exitDictionary.Add(currentRoom.exits[i].keyString, currentRoom.exits[i].valueRoom);            
            controller.interactiveDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }

    public void UnpackExaminablesInRoom()
    {
        for (int i = 0; i < currentRoom.examinableObjectsInRoom.Length; i++)
        {
            examineDictionary.Add(currentRoom.examinableObjectsInRoom[i].noun, currentRoom.examinableObjectsInRoom[i].description);
            controller.examinableDescriptionsInRoom.Add(currentRoom.examinableObjectsInRoom[i].noun);
        }
    }

    public void AttemptToChangeRooms(string directionNoun)
    {
        if (exitDictionary.ContainsKey(directionNoun))
        {
            currentRoom = exitDictionary[directionNoun];
            controller.LogStringWithReturn("You head to the " + directionNoun);
            controller.DisplayRoomText();
            player.CurrentRoom = currentRoom;
            player.PlayerCurrentRoom = currentRoom.roomCode;
        }
        else
        {
            controller.LogStringWithReturn("There is no exit to the " + directionNoun);
        }
    }

    public void LookDirection(string directionNoun)
    {
        if (exitDictionary.ContainsKey(directionNoun))
        {

        }
    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }

    public void ClearExaminables()
    {
        examineDictionary.Clear();
    }
}
