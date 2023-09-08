using UnityEngine;

public class AtributHero : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] int healthPoint;
    [SerializeField] int damagePerSecond;
    [SerializeField] bool isDead;
    [SerializeField] float interval = 1f;
    float timer = 0f;

    void Start()
    {
        Debug.Log("Name : " + name);
        Debug.Log("Health Point : " + healthPoint);
        Debug.Log("Damage : " + damagePerSecond);
        Debug.Log("Is Dead : " + isDead);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            if (healthPoint <= 0)
            {
                isDead = true;
                Debug.Log("Dead");
            }
            else
            {
                healthPoint -= damagePerSecond;
            }
            Debug.Log("Health Point : " + healthPoint);
            timer = 0;
        }
        if (isDead)
        {
            this.gameObject.SetActive(false);
        }
    }
}
