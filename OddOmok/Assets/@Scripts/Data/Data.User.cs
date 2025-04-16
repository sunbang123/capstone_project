using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Data
{
    #region TestData
    [Serializable]
    public class TestData
    {
        public int Id;
        public string Name;
        public int BlackGamePlayed;
        public int WhiteGamePlayed;
        public int BlackWins;
        public int WhiteWins;
    }

    [Serializable]
    public class TestDataLoader : ILoader<int, TestData>
    {
        public List<TestData> tests = new List<TestData>();

        public Dictionary<int, TestData> MakeDict()
        {
            Dictionary<int, TestData> dict = new Dictionary<int, TestData>();
            foreach (TestData testData in tests)
                dict.Add(testData.Id, testData);

            return dict;
        }
    }
    #endregion
}