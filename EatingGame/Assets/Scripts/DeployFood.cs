using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployFood : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bananaPrefab;
    public GameObject eggPrefab;
    public GameObject strawberryPrefab;

    private Vector2 screenBounds;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(appleWave());
        StartCoroutine(bananaWave());
        StartCoroutine(eggWave());
        StartCoroutine(strawberryWave());

    }

    private void spawnApple()
    {
        GameObject a = Instantiate(applePrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnBanana()
    {
        GameObject a = Instantiate(bananaPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnEgg()
    {
        GameObject a = Instantiate(eggPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnStrawberry()
    {
        GameObject a = Instantiate(strawberryPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }

    IEnumerator appleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            spawnApple();
        }
    }
    IEnumerator bananaWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            spawnBanana();
        }
    }
    IEnumerator eggWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            spawnEgg();
        }
    }
    IEnumerator strawberryWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            spawnStrawberry();
        }
    }
}
    
