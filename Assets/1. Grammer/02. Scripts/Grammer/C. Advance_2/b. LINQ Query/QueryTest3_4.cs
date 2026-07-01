using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class QueryTest3_4 : MonoBehaviour
{
    List<string> words = new List<string>
    {
        "Apple",
        "Banana",
        "Cherry",
        "Date",
        "Fig",
        "Grape",
        "Kiwi"
    };

    private void Start()
    {
        var groupedWords = from word in words
                           group word by word.Length into wordGroup
                           orderby wordGroup.Key
                           select wordGroup;
        
        foreach (var group in groupedWords)
        {
            Debug.Log($"Length : {group.Key}");

            foreach (var word in group)
                Debug.Log($"   {word}");
        }
    }
}
