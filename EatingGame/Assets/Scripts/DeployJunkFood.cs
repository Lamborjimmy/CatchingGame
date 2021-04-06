using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployJunkFood : MonoBehaviour
{
    public GameObject burgerPrefab;
    public GameObject donutPrefab;
    public GameObject friesPrefab;
    public GameObject doritosPrefab;
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
        GameObject a = Instantiate(burgerPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnDonut()
    {
        GameObject a = Instantiate(donutPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnFries()
    {
        GameObject a = Instantiate(friesPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnDorito()
    {
        GameObject a = Instantiate(doritosPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    IEnumerator burgerWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(4, 9));
            spawnBurger();
        }
    }
    IEnumerator donutWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(4, 9));
            spawnDonut();
        }
    }
    IEnumerator friesWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(4, 9));
            spawnFries();
        }
    }
    IEnumerator doritosWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(4, 9));
            spawnDorito();
        }
    }

}
