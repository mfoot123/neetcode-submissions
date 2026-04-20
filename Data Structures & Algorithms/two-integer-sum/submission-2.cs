public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> lookupTable = new Dictionary<int, int>();
        int[] result = new int[2];

        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if(lookupTable.ContainsKey(diff))
            {
                result[0] = lookupTable[diff];
                result[1] = i;
                break;
            }

            lookupTable[nums[i]] = i;
        }

        return result;
    }
}