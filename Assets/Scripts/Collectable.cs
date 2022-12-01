using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollectableType{
    healthPotion,
    manaPotion,
    money
}


public class Collectable : MonoBehaviour{

    public CollectableType type = CollectableType.money;

    private SpriteRenderer sprite;
    private CircleCollider2D itemCollider;

    bool hasBeenCollected = false;

    public int value = 1;

    GameObject player;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        itemCollider = GetComponent<CircleCollider2D>();
    }

    private void Start()
    {
        player = GameObject.Find("Player")
    }

    void Show(){
        sprite.enabled = true;
        itemCollider.enabled = true;
        hasBeenCollected = false;
    }


    void Hide(){
        sprite.enabled = false;
        itemCollider.enabled = false;
    }

    void Collect(){
        Hide();
        hasBeenCollected = true;

        switch(this.type){
            case CollectableType.money:
                GameManager.sharedInstance.CollectedObject(this);
            break;

            case CollectableType.healthPotion:
                player.GetComponent<PlayerController>().CollectHealth(this.value);
            break;

            case CollectableType.manaPotion:
                player.GetComponent<PlayerController>().CollectMana(this.value);
            break;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
            Collect();
        }
    }
}
