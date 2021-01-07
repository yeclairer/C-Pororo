using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    private GameObject Netflix1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateNetflix1Routine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator CreateNetflix1Routine()
    {
        while(true)
        {
            CreateNetflix1();
            yield return new WaitForSeconds(1);
        }
    }
    private void CreateNetflix1()
    {
        Vector3 pos = new Vector3(0, 6, 0);
        Instantiate(Netflix1, pos, Quaternion.identity);
    }
}
