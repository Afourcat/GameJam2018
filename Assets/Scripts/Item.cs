using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum itemId {
    HERBS,
    ROCKS,
    POWDERS,
    LIQUIDES
}

public enum itemColor {
    RED,
    BLUE,
    GREEN,
    YELLOW
}

public class Item : MonoBehaviour {
 
    private static string[] stringId = {"Herbs", "Rocks", "Powders", "Liquides"};

    private static string[] stringColor = {"Red", "Blue", "Green", "Yellow"};

    private Sprite itemSprite;

    private itemId id;

    private itemColor color;

    private SpriteRenderer sr;

    public void init(itemId id, itemColor color) {
        this.id = id;
        this.color = color;
        sr = GetComponent<SpriteRenderer>();
        setSprite();
    }

    private void setSprite()
    {
        for (int i = 0; i < stringId.Length; i++) {
            for (int y = 0; y < stringColor.Length; y++) {
                if (i == (int)this.id && y == (int)this.color) {
                    if (sr)
                        sr.sprite = Resources.Load <Sprite> ("Sprites/" + stringId[i] + "_" + stringColor[y]);
                }
            }
        }
    }

    public Sprite ItemSprite {
        get {
            return itemSprite;
        }

        set {
            itemSprite = value;
        }
    }

    internal itemId Id {
        get {
            return id;
        }

        set {
            id = value;
        }
    }

    internal itemColor Color {
        get {
            return color;
        }

        set {
            color = value;
        }
    }
}
