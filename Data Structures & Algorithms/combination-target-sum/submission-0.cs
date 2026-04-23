public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();
        List<int> path = new List<int>();

        BackTrack(nums, 0, target, path, result);

        return result;
    }

    void BackTrack(int[] nums, int index, int target, List<int> path, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(path));
            return;
        }

        if (target < 0)
        {
            return;
        }

        for (int i = index; i < nums.Length; i++)
        {
            path.Add(nums[i]);

            BackTrack(nums, i, target - nums[i], path, result);

            path.RemoveAt(path.Count - 1);
        }
    }
}