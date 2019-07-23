using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadTxt : MonoBehaviour {
    [System.Serializable]
    public struct KanjiCard
    {
        public int id;
        public string kanji;
        public string furigana;
        public string translate;
    }
    public TextAsset kanjiList;
    public List<KanjiCard> kards;
    // Use this for initialization
    void Start()
    {
        kards = new List<KanjiCard>();
        string[] data = kanjiList.text.Split(new char[] { '\n' });
        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            if (row[1] != "")
            {
                KanjiCard k;
                int.TryParse(row[0], out k.id);
                k.kanji = row[1];
                k.furigana = row[2];
                k.translate = row[3];
                kards.Add(k);
            }
    
        }
    }

 
}
