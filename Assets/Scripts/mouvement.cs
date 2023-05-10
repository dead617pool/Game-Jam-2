using UnityEngine;

public class Mouvement : MonoBehaviour
{
    [SerializeField]
    private int maxMouvement;
    [SerializeField]
    private int mouvement;
    [SerializeField]
    private int minMouvement;
    [SerializeField]
    private bool canmoove = true;
    private void Start()
    {
        
    }
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Z) && mouvement < maxMouvement)
            {
            transform.Translate(0, 5f, 0);
                mouvement++;
            }
            else if (Input.GetKeyDown(KeyCode.S) && mouvement > -minMouvement)
            {
            transform.Translate(0, -5f, 0);
                mouvement--;
            }
            canmoove =true;
        
    }
}
