using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy_netflix;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateNetflixRountine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateNetflixRountine()
    {
        while(true)
        {
            CreateNetflix();
            yield return new WaitForSeconds(1);
        }
    }
    private void CreateNetflix()
    {
        Vector3 pos = new Vector3(0, 6, 0);
        Instantiate(enemy_netflix, pos, Quaternion.identity);
    }
}
