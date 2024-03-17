using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tutorial
{
    public class PlayerUI : MonoBehaviour
    {
        [SerializeField] private GameObject[] hearts;
        [SerializeField] private TextMeshProUGUI treeCountText;
        [SerializeField] private GameObject _curtain;
        
        
        private int _treeCount;

        private void OnEnable()
        {
            _curtain.SetActive(false);
        }

        public void SetHealth(int health)
        {
            if(health > hearts.Length) return;

            for (int i = 0; i < hearts.Length; i++)
            {
                hearts[i].SetActive(health > i);
            }
        }

        public int TreeCount
        {
            get => _treeCount;
            set
            {
                _treeCount = value;
                
                treeCountText.SetText(_treeCount.ToString());
            }
        }

        public void GoToMenu()
        {
            SceneManager.LoadScene(0);
        }
        
        public void ShowDieCurtain()
        {
            _curtain.SetActive(true);
        }
    }
}