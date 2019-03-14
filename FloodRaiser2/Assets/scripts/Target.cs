using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 50f;

    //amount talks about how much there is taken damage
    //amount is going to be equal to the damage of the gun
    //health gets les when amounts gets higher
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
