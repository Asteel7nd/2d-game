using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanete : MonoBehaviour
{
    public GameObject planet1;
    public GameObject planet2;
    public GameObject planet3;
    public GameObject planet4;
    public GameObject planet5;
    public Vector2 center; // координаты центра
    //public Vector2 size; // координаты в которых будут появляться объекты

    void Start()
    {
        for (int i = 0; i <= 3; i++)
        {
            Spawn();
        }
    }

    private void Update()
    {
        
    }

    public void Spawn()
    {
        Vector2 pos = center + new Vector2(Random.Range(60, 1380), Random.Range(40, 600));
        Instantiate(planet1, pos, Quaternion.identity); // осуществляем появление объекта в заданных случайных позициях в диапазоне заданных координат

        Vector2 pos2 = center + new Vector2(Random.Range(60, 1380), Random.Range(40, 600));
        Instantiate(planet2, pos2, Quaternion.identity);

        Vector2 pos3 = center + new Vector2(Random.Range(60, 1380), Random.Range(40, 600));
        Instantiate(planet3, pos3, Quaternion.identity);

        Vector2 pos4 = center + new Vector2(Random.Range(60, 1380), Random.Range(40, 600));
        Instantiate(planet4, pos4, Quaternion.identity);

        Vector2 pos5 = center + new Vector2(Random.Range(60, 1380), Random.Range(40, 600));
        Instantiate(planet5, pos5, Quaternion.identity);
    }
}
