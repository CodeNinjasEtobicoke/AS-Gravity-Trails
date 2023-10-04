using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public static int enemyCount;
    private bool isUsed = false;

    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(enemyCount);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == "Player" && enemyCount == -12 && !isUsed)
        {
            isUsed = true;
            SceneManager.LoadScene(2);
            Debug.Log("QASWEDFRTGHYUJIKOLP");
        }
    }
}
