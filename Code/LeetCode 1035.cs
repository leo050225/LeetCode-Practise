public class Solution {
    public int MaxUncrossedLines(int[] nums1, int[] nums2) 
	{
		int[,] dp = new int[nums1.Length+1,nums2.Length+1];

		for(int i = 1; i<=nums1.Length; i++)//也是在求最長公共子序列
		{
			for(int j = 1; j<=nums2.Length; j++)
			{
				if(nums1[i-1] == nums2[j-1])
				{
					dp[i,j] = dp[i-1,j-1]+1;
				}
				else
				{
					dp[i,j] = Math.Max(dp[i-1,j] , dp[i,j-1]);
				}
			}
		}
		return dp[nums1.Length , nums2.Length];
    }
}
