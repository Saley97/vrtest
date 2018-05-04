﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public float hp = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReciveDamage(float dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            if (GameManager.gameManager != null)
            {
                GameManager.gameManager.EnemyDie();
            }
            Destroy(gameObject);
        }
    }
}
