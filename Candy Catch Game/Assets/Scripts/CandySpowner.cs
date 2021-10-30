using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpowner : MonoBehaviour
{
    [SerializeField]
    float maxX;

    [SerializeField]
    GameObject[] Candies;

    [SerializeField]
    float spawnInterval;

    public static CandySpowner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;        
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //SpawnCandy();

        StartSpawingCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int rand = Random.Range(0, Candies.Length);

        float randomX = Random.Range(-maxX, maxX);

        Vector3 ramdomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        Instantiate(Candies[rand], ramdomPos, transform.rotation);
    }

    IEnumerator SpownCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        
        }
    }

    public void StartSpawingCandies()
    {
        StartCoroutine("SpownCandies");
    

    }

    public void StopSpowingCandies()
    {
        StopCoroutine("SpownCandies");

    }

}
