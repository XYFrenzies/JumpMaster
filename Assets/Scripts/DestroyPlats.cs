﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlats : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject platformPrefab;
    private GameObject myPlatform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlatform = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (1 + Random.Range(0.5f, 1f))), Quaternion.identity);
        Destroy(collision.gameObject);
    }
}
