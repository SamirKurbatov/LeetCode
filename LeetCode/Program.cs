using LeetCode.Easy;

var s = RomanToInt.Execute("IV");

var strs = new string[] { "flower", "flow", "flight" };

var brackets = "(}";

var res = LongestCommonPrefix.Execute(strs);

var res2 = ValidPairbrackets.Execute(brackets);

var ss = MergeList.MergeTwoLists(new ListNode(124), new ListNode(134));

var result = RemoveDuplicatesFromArray.Execute(new int[] { 1,1,2});

foreach (var item in result)
{
    Console.WriteLine(item);
}
