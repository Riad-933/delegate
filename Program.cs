int[] nums = { 5, 1, 9, 6, 4, 2 };

int max = nums[0];
int min = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] <= min)
    {
        min = nums[i];
    }
    else if (nums[i]>=max)
    {
        max = nums[i];
    }
}

Console.WriteLine($"{min},{max}");

