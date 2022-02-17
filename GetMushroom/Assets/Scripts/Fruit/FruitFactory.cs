using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fruit
{
    class FruitFactory : MonoBehaviour
    {
        bool Gen = false;
        public GameObject[] FruitPrefabs;

        public void StartGenFruit()
        {
            Gen = true;
        }

        public void StopGenFruit()
        {
            Gen = false;
        }

        private void Start()
        {
            StartCoroutine(GenFruit());
        }

        private void Update()
        {
            
            
        }

        IEnumerator GenFruit()
        {
            Random.InitState(Time.frameCount);
            while (true)
            {
                int i = Random.Range(0, FruitPrefabs.Length - 1);
                GameObject go = Instantiate(FruitPrefabs[i], this.transform);

                Rigidbody r = go.GetComponent<Rigidbody>();
                r.velocity = new Vector3(Random.Range(0, 1), 0, Random.Range(0, 1));
            }
        }
    }
}
