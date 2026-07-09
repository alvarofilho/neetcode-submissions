public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>(nums.Length);

        for (var i = 0; i < nums.Length; i++) {
            var complement = target - nums[i];

            if (map.TryGetValue(complement, out int index)) {
                return [index, i];
            }

            map[nums[i]] = i;
        }

        return [];
    }
}