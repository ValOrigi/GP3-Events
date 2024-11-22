using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int spawnNum;
    [SerializeField] private GameObject spawnOBJ;
    [SerializeField] private Vector2 spawnPosX;
    [SerializeField] private Vector2 spawnPosY;
    private void Start()
    {
        for (int i = 0; i < spawnNum; i++)
        {
            float xpos = Random.Range(spawnPosX.x, spawnPosX.y);
            float zpos = Random.Range(spawnPosY.x, spawnPosY.y);
            Vector3 pos = new Vector3(xpos, 1, zpos);
            Instantiate(spawnOBJ, pos, Quaternion.identity);
        }
    }
}
