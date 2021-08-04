using System;
using System.Collections;
using System.Linq;

namespace TwoSum
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var hashTable = new Hashtable();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (!hashTable.ContainsKey(nums[i]))
                    hashTable.Add(nums[i], i);

                int remaining = target - nums[i];
                if (hashTable.ContainsKey(remaining) 
                    && (int)hashTable[remaining] != i)
                    return new int[] { (int)hashTable[remaining], i };
            }

            throw new ArgumentException("Two sum not found");
        }
    }
}