using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJunkyFood : MonoBehaviour
{
    public GameObject burger;
    public GameObject donut;
    public GameObject fries;
    public GameObject doritos;
    private Vector2 screenBounds;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(burgerWave());
        StartCoroutine(donutWave());
        StartCoroutine(friesWave());
        StartCoroutine(doritosWave());

    }

    private void spawnBurger()
    {
        GameObject a = Instantiate(burger) as GameObject;
        a.transform.position = new Vector2(Random.Range(1, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnDonut()
    {
        GameObject a = Instantiate(donut) as GameObject;
        a.transform.position = new Vector2(Random.Range(1, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnFries()
    {
        GameObject a = Instantiate(fries) as GameObject;
        a.transform.position = new Vector2(Random.Range(1, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnDorito()
    {
        GameObject a = Instantiate(doritos) as GameObject;
        a.transform.position = new Vector2(Random.Range(1, screenBounds.x), screenBounds.y * 2);
    }
    IEnumerator burgerWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnBurger();
        }
    }
    IEnumerator donutWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnDonut();
        }
    }
    IEnumerator friesWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnFries();
        }
    }
    IEnumerator doritosWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            spawnDorito();
        }
    }

}
