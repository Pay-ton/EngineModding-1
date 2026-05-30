using UnityEngine;

public class Key1 : MonoBehaviour
{
     public GameObject door;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerImported>())
        {
            collision.gameObject.GetComponent<PlayerImported>().HasKey = true;

            door.SetActive(false);
            return;
        }
    }
}
