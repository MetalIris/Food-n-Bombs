using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakePointScript : MonoBehaviour
{
    public int schore = 0;
    public TextMeshProUGUI schoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Destroy(collision.gameObject);
            schore++;
            schoreText.text = schore.ToString();
        }
    }
    private void Update()
    {
        if (schore == 30)
        {
            SceneManager.LoadScene(2);
        }
    }
}
