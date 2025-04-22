//Kadin Meyer
//4/22/2025

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int n = nums.Length;

        for (int i = 0; i < n - 1; i++)
        {
            if (nums[i] == 0)
            {
                for (int j = i; j < n - 1; j++)
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }
                i--;
                n--;
            }
        }
    }
}
