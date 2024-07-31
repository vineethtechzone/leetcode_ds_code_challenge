// Two Sum Leetcode problem solving by using Dictionary (Heap
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> pre_map = new Dictionary<int, int>();
        var result = new int[2];
     for (var i = 0; i < nums.Length; i ++) 
     {       
         if (pre_map.ContainsKey(target-nums[i]))
         {
          result[0]=pre_map[target-nums[i]];
          result[1]=i;
          return result;
         } else
         {
             pre_map[nums[i]] = i;
         }000
     }
       return result;
    }
}
