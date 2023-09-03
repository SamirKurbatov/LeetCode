using LeetCode.Easy;

var array = new int[] { 2, 2, 4, 6 };

var target = 6;

var result = TwoSum.Execute(array, target);

foreach (var item in result)
{
    Console.Write(item + " ");
}

Console.WriteLine(Polindrome.IsPalindorme(1222221));