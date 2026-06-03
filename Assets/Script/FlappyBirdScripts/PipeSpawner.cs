using Unity.Hierarchy;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 1f;
    [SerializeField] private GameObject pipa;

    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipa();
    }

    private void spawnPipa()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-0.45f, heightRange));
        GameObject pipe = Instantiate(pipa, spawnPos, Quaternion.identity);
        Destroy(pipe, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            spawnPipa();
            timer = 0;

        }
            timer += Time.deltaTime;
    }
}
