using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace sei
{
    public class Distribute : MonoBehaviour
    {
        [SerializeField]
        private GameObject cardPrefab;
        [SerializeField]
        public List<GameObject> myCards;

        //�J�[�h�̏����ʒu�ƊԊu
        [SerializeField]
        private Vector2 firstCardTransform;
        [SerializeField]
        private Vector2 distance;

        //�J�[�h���o���Ԋu
        [SerializeField]
        private float cardTime;

        [SerializeField]
        private int maxCards = 11;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            myCards = new List<GameObject>();
            startCards();
            Invoke("startCards",cardTime);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void hit()
        {
            if(myCards.Count >= maxCards)
            {
                Debug.Log("����ȏ�J�[�h�͈����܂���");
                return;
            }
            myCards.Add(Instantiate(cardPrefab, firstCardTransform + distance * myCards.Count, Quaternion.identity));
            //GameObject newCard = Instantiate(cardPrefab, firstCardTransform + distance * myCards.Count, Quaternion.identity);
        }
        //�ŏ��ɔz���J�[�h
        public void startCards()
        {
            myCards.Add(Instantiate(cardPrefab, firstCardTransform + distance * myCards.Count, Quaternion.identity));
            //GameObject newCard = Instantiate(cardPrefab, firstCardTransform + distance * myCards.Count, Quaternion.identity);
        }
        public void ClearDeck()
        {
            for (int i = 0; i < myCards.Count; i++)
            {
                Destroy(myCards[i]);
            }
            myCards.Clear();
        }
    }
}
