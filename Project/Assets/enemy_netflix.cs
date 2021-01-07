using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_netflix: MonoBehaviour
{
    [SerializeField]
    private GameObject netflix;
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
        while (true)
        {
            CreateNetflix();
            yield return new WaitForSeconds(1);
        }
    }
    private void CreateNetflix()
    {
        Vector3 pos = new Vector3(0, 6, 0);
        Instantiate(netflix, pos, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag=="player"){
        Destroy(this.gameObject);
        }
    }

}
