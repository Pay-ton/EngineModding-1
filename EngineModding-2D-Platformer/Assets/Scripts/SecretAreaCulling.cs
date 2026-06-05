using UnityEngine;

public class SecretAreaCulling : MonoBehaviour

{
    public Collider2D[] col;
    public Renderer[] renderers;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         

    }

    // Update is called once per frame
    void Update()
    {
        for (int h = 0; h < col.Length; h++)
        {
            Collider2D[] hits = new Collider2D[10];

            bool inside = false;


            // check for overlaping objects
            col[h].Overlap(new ContactFilter2D(), hits);

            // If no hit then leave
            if (hits.Length <= 0) return;

            // go throught hits array and find object with tag
            for (int i = 0; i < hits.Length; i++)
            {
                if (!hits[i] || !hits[i].enabled) continue;

                if (hits[i].CompareTag("Player"))
                {
                    print("KK");

                    inside = true;
                    for (int j = 0; j < renderers.Length; j++)
                    {
                        renderers[j].enabled = false;
                    }
                    return;
                }
            }

            if (!inside)
            {
                for (int j = 0; j < renderers.Length; j++)
                {
                    renderers[j].enabled = true;
                }
            }
        }
    }
}





