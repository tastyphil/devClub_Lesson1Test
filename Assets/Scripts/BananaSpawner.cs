using UnityEditor;
using UnityEngine;

public class BananaSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bananaPrefab, map;
    public Collider2D spawnableArea;
    [SerializeField] private LayerMask mapLayer;
    void Start()
    {
        spawnableArea = map.GetComponent<Collider2D>();
        spawnBanana(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Spawn Banana")]
    public void spawnBanana()
    {   
        Vector2 spawnPosition = getRandomPositionInArea(spawnableArea);
        bool collidesOn = Physics2D.OverlapCircle(spawnPosition, 0.25f);

        while (collidesOn)
        {
            spawnPosition = getRandomPositionInArea(spawnableArea);
            collidesOn = Physics2D.OverlapCircle(spawnPosition, 0.25f);
        }
        Instantiate(bananaPrefab, spawnPosition, Quaternion.identity);
        
    }

    private Vector2 getRandomPositionInArea(Collider2D area)
    {
        return new Vector2(
            Random.Range(area.bounds.min.x, area.bounds.max.x),
            Random.Range(area.bounds.min.y, area.bounds.max.y)
        );
    }
}
