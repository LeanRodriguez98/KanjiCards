using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadTxt : MonoBehaviour {
    public static ReadTxt instance;
    [System.Serializable]
    public struct KanjiCardData
    {
        public int id;
        public string kanji;
        public string furigana;
        public string translate;
    }
    public TextAsset kanjiList;
    public List<KanjiCardData> cards;
    private void Awake()
    {
        instance = this;

        cards = new List<KanjiCardData>();
        string[] data = kanjiList.text.Split(new char[] { '\n' });
        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            if (row[1] != "")
            {
                KanjiCardData k;
                int.TryParse(row[0], out k.id);
                k.kanji = row[1];
                k.furigana = row[2];
                k.translate = row[3];
                cards.Add(k);
            }

        }
    }
    void Start()
    {
       
    }

 
}
