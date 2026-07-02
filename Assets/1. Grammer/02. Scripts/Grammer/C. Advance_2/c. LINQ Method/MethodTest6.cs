using System.Linq;
using UnityEngine;

public class MethodTest6 : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    private void Start()
    {
        var total = numbers.Sum();
        var average = numbers.Average();
        var min = numbers.Min();
        var max = numbers.Max();

        Debug.Log($"Total: {total}, Average: {average}, Min: {min}, Max: {max}");

        // first : 첫번째 요소
        // last : 마지막 요소
        var first = numbers.First();
        var firstEven = numbers.FirstOrDefault(n => n % 2 == 0);
        var last = numbers.Last();
        var lastEven = numbers.LastOrDefault(n => n % 2 == 0);

        Debug.Log($"First: {first}, First Even: {firstEven}, Last: {last}, Last Even: {lastEven}");

        // Any : 조건에 맞는 하나 이상의 요소가 있는지 확인
        // All : 모든 요소가 조건에 맞는지 확인
        var hasEven = numbers.Any(n => n % 2 == 0);
        var allPositive = numbers.All(n => n > 0);

        Debug.Log($"Has Even: {hasEven}, All Positive: {allPositive}");

        // Contains : 컬렉션에 특정 요소가 포함되어 있는지 확인
        var containsTen = numbers.Contains(10);

        Debug.Log($"Contains 10: {containsTen}");

        // Distinct : 컬렉션에서 중복된 요소를 제거
        int[] nums = { 1, 2, 2, 3, 4, 4, 5 };

        var distinctNumbers = nums.Distinct();

        foreach (var num in distinctNumbers)
            Debug.Log(num);

        // Take : 지정된 수만큼 요소를 가지고 옴
        // Skip : 지정된 수만큼 요소를 건너뜀
        var firstThree = numbers.Take(3);
        var skippedThree = numbers.Skip(3);

        Debug.Log("First Three:");
        foreach (var num in firstThree)
            Debug.Log(num);

        Debug.Log("Skipped Three:");
        foreach (var num in skippedThree)
            Debug.Log(num);
    }
}
