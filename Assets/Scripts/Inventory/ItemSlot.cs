﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public enum EquipmentType
{
    Head, Shoulders, Arms, Hands, Chest, Waist, Legs, Feet, Neck, Finger1, Finger2, Ear1, Ear2, Weapon1, Weapon2
}

public class ItemSlot : MonoBehaviour, IPointerClickHandler {

    [SerializeField] Image image;

    public event Action<Items> OnRightClickEvent;

    private Items _item;
    public Items Item
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item == null)
            {
                image.enabled = false;
            }
            else
            {
                image.sprite = _item.itemIcon;
                image.enabled = true;
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData != null && eventData.button == PointerEventData.InputButton.Right)
        {
            if (Item != null && OnRightClickEvent != null)
            {
                OnRightClickEvent(Item);
            }
        }
    }

    protected virtual void OnValidate()
    {
        if (image == null)
        {
            image = GetComponent<Image>();
        }
    }
}
