public class Solution {
  public int[] TwoSum(int[] nums, int target) {
    var pairs = new(int val, int idx)[nums.Length];

    for (var i = 0; i < nums.Length; i++) {
      pairs[i] = (nums[i], i);
    }

    Array.Sort(pairs, (a, b) => a.val.CompareTo(b.val));

    int lo = 0, hi = nums.Length - 1;
    while (lo < hi) {
      var sum = pairs[lo].val + pairs[hi].val;
      if (sum == target) {
        var first = Math.Min(pairs[lo].idx, pairs[hi].idx);
        var second = Math.Max(pairs[lo].idx, pairs[hi].idx);
        return [first, second];
      }

      if (sum < target) {
        lo++;
      } else {
        hi--;
      }
    }
    return [];
  }
}