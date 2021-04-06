using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawn : MonoBehaviour
{
    public GameObject brickPrefab;
    public GameObject cdPrefab;
    public GameObject shoePrefab;
    

    private Vector2 screenBounds;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(brickWave());
        StartCoroutine(cdWave());
        StartCoroutine(shoeWave());
        

    }

    private void spawnBrick()
    {
        GameObject a = Instantiate(brickPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnCD()
    {
        GameObject a = Instantiate(cdPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    private void spawnShoe()
    {
        GameObject a = Instantiate(shoePrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }
    

    IEnumerator brickWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 8));
            spawnBrick();
        }
    }
    IEnumerator cdWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            spawnCD();
        }
    }
    IEnumerator shoeWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            spawnShoe();
        }
    }
    
}
