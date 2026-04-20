public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {

        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int removals = 0;
        int prevEnd = intervals[0][1];

        for(int i = 1; i < intervals.Length; i++)
        {
            int currentStart = intervals[i][0];
            int currentEnd = intervals[i][1];

            if(currentStart < prevEnd)
            {
                removals++;
            }
            else
            {
                prevEnd = currentEnd;
            }
        }

        return removals;
    }
}
