using UnityEngine;

namespace Tutorial
{
    [RequireComponent(typeof(Collider))]
    public sealed class npc : MonoBehaviour
    {
        [SerializeField] private EnemySpawner _enemySpawner;
        [SerializeField] private GameObject _dialogeObj;
        [SerializeField] private DialogSystem _dialogSystem;
        
        
        private bool flag;
        
        private void Start()
        {
            flag = false;
            _dialogeObj.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            if(_enemySpawner.enemyCounter < _enemySpawner.EnemyCount) return;
            
            if(flag) return;
            flag = true;
            _dialogeObj.SetActive(true);
            _dialogSystem.StartDialog();
        }
    }
}