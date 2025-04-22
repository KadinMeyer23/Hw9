//Kadin Meyer
//4/22/2025

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> myDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (myDict.ContainsKey(nums[i]))
            {
                myDict[nums[i]] += 1;
            }
            else
            {
                myDict.Add(nums[i], +1);
            }
        }
        int maxScore = myDict.Values.Max();
        int foundKey = 0;
        foreach (var x in myDict)
        {
            if (x.Value == maxScore)
            {
                foundKey = x.Key;
                break;
            }
        }
        return foundKey;
    }
}