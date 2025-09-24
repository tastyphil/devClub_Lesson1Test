using UnityEngine;

public class BananaBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ScoreManager scoreManager;
    public BananaSpawner bananaSpawner;

    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
        bananaSpawner = GameObject.FindGameObjectWithTag("BananaManager").GetComponent<BananaSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player touched the banana!");
            AudioManager.Instance.playSfx("swallow");
            Destroy(gameObject);
            scoreManager.IncreaseScore();
            bananaSpawner.spawnBanana();
        }
    }

}
