using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [System.Serializable]
    public class PlayerStat
    {
        public bool Alive = true;
    }

    public Animator animator;
    public PlayerMovement pm;
    [SerializeField] private GameObject GameOverUI;
    [SerializeField] private GameObject WinUI;
    public PlayerStat Pstat = new PlayerStat();
    public int fallBoundary = -5;

    void Update()
    {
        if (transform.position.y <= fallBoundary)
        {
            DamagePlayer();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("WIN GAME");
            WinUI.SetActive(true);
            animator.SetBool("Finish", true);
        }
        else if (other.gameObject.tag == "GameOver")
        {
            Debug.Log("Game Over");
            animator.SetBool("Dead", true);
            GameOverUI.SetActive(true);
        }
    }

    public void DamagePlayer()
    {
        Pstat.Alive = false;
        if (Pstat.Alive == false)
        {
            Destroy(this.gameObject);
            GameOverUI.SetActive(true);
        }
    }
}
